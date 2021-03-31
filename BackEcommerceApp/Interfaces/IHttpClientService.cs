using System.Threading.Tasks;

namespace BackEcommerceApp.Interfaces
{
    public interface IHttpClientService
    {
        Task<string> GetProductsAsync(string urlEndPoint);
        Task<string> GetCategoryAsync(string urlEndPoint);
    }
}
