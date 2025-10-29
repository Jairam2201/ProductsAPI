using System.Net.Http;
using System.Threading.Tasks;

namespace ProductsAPI.Services
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetCurrencyDataAsync(string from)
        {
            string apiUrl = $"https://api.exchangerate-api.com/v4/latest/{from}";
            var response = await _httpClient.GetStringAsync(apiUrl);
            return response;
        }
    }
}
