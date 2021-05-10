using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyBankApp.Api.Http
{
    public class ExchangeRate
    {
        [JsonProperty(PropertyName = "base")]
        public string Bserate { get; set; }

        [JsonProperty(PropertyName = "rates")]
        public Dictionary<string, double> Rates { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }
    }


    public class Rate     
    { 
        public Dictionary<string, double> RateValue { get; set; }
    }

}
