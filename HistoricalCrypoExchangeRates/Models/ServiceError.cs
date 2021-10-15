using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricalCrypoExchangeRates.Models
{
    public class ServiceError
    {
        public int Code { get; set; }
        public string Type { get; set; }
        public string Info { get; set; }
    }
}
