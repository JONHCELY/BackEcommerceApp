using BackEcommerceApp.Interfaces;
using BackEcommerceApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEcommerceApp.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IHttpClientService _httpClientService;
        public ProductsService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }
        public async Task<IList<ProductsModel>> GetProducts()
            => await _getProducts();
        private async Task<IList<ProductsModel>> _getProducts()
        {
            try
            {
                string json = await _httpClientService.GetProductsAsync("products/search");
                var listCategory = (List<ProductsModel>)JsonConvert.DeserializeObject(json,
                    typeof(List<ProductsModel>));
                listCategory ??= new List<ProductsModel>();
                return listCategory;
            }
            catch (Exception ex)
            {
                return new List<ProductsModel>();
            }
        }
    }
}
