using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricalCrypoExchangeRates.Models
{
    public class ServiceResponse
    {
        public bool Success { get; set; }
        public string Target { get; set; }
        public DateTime? Date { get; set; }
        public Dictionary<string, double> Rates { get; set; }
        public ServiceError Error { get; set; }
        public bool LoadedFromCache { get; set; }
    }
}
