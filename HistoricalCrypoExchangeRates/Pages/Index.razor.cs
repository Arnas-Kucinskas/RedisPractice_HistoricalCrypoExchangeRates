using HistoricalCrypoExchangeRates.Models;
using HistoricalCrypoExchangeRates.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricalCrypoExchangeRates.Pages
{
    public partial class  Index
    {
        [Inject]
        protected IExchangeRateService _exchangeRateService { get; set; }


        public DateTime? ExchangeRateDate = DateTime.Now;
        public ServiceResponse RatesResponse = null;

        protected async void GetHistoricData()
        {
            RatesResponse = await _exchangeRateService.GetHistoricalData(ExchangeRateDate);
            await InvokeAsync(StateHasChanged);
        }
    }
}
