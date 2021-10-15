using HistoricalCrypoExchangeRates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricalCrypoExchangeRates.Services
{
    public interface IExchangeRateService
    {
        public Task<ServiceResponse> GetHistoricalData(DateTime? dateTime);
    }
}
