using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using System.Net.Http.Json;
using HistoricalCrypoExchangeRates.Models;
using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;
using HistoricalCrypoExchangeRates.Extensions;

namespace HistoricalCrypoExchangeRates.Services
{
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly IDistributedCache _redisCache;
        private const string cacheKey = "historicData_";
        public ExchangeRateService(HttpClient httpClient, IConfiguration configuration, IDistributedCache redisCache)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _redisCache = redisCache;
        }

        public async Task<ServiceResponse> GetHistoricalData(DateTime? dateTime)
        {
            if (dateTime is null)
            {
                return null;
            }
            var dateString = dateTime.Value.ToString("yyyy-MM-dd");

            var historicData = await GetHistoricDataFromCache(dateString);
            if (historicData is null)
            {
                historicData = await GetHistoricDataFromApi(dateString);
            }
            return historicData;
        }

        private async Task<ServiceResponse> GetHistoricDataFromApi(string dateString)
        {
            try
            {
                var address = _httpClient.BaseAddress + dateString + $"?access_key={_configuration.GetValue<string>("CoinLayerApiKey")}";
                var result = await _httpClient.GetFromJsonAsync<ServiceResponse>(address);
                await _redisCache.SetRecordAsync<ServiceResponse>(cacheKey + dateString, result);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        private async Task<ServiceResponse> GetHistoricDataFromCache(string dateString)
        {
            var historicData = await _redisCache.GetRecordAsync<ServiceResponse>(cacheKey + dateString);
            if (historicData is not null)
            {
                historicData.LoadedFromCache = true;
            }
            return historicData;
        }
    }
}
