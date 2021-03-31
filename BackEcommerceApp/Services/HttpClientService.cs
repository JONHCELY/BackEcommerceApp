using BackEcommerceApp.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace BackEcommerceApp.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;
        public HttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetProductsAsync(string urlEndPoint)
            => await _getAsync(urlEndPoint);
        public async Task<string> GetCategoryAsync(string urlEndPoint)
            => await _getAsync(urlEndPoint);

        private async Task<string> _getAsync(string urlEndPoint)
        {
            HttpResponseMessage result = await _httpClient.GetAsync(urlEndPoint);
            string valueResult = (result.IsSuccessStatusCode) ? await result.Content.ReadAsStringAsync()
                : result.ReasonPhrase;
            return valueResult;
        }
    }
}
