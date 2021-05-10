using MyBankApp.Api.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyBankApp.Api
{
    public class MyExchangeRateClient
    {
        private readonly HttpClient httpclient;

        public MyExchangeRateClient(HttpClient _httpclient)
        {
            httpclient = _httpclient;
        }

        public async Task<ExchangeRate> Get(string uri)
        {
            var res= httpclient.GetAsync(uri).Result;
            res.EnsureSuccessStatusCode();
            var data = await res.Content.ReadAsStringAsync();

            var deser = JsonConvert.DeserializeObject<ExchangeRate>(data);
            return deser;
        }
    }
}
