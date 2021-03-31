using BackEcommerceApp.Interfaces;
using BackEcommerceApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEcommerceApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IHttpClientService _httpClientService;
        public CategoryService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }
        public async Task<IList<CategoryModel>> GetCategorys()
            => await _getCategorys();
        public async Task<CategoryModel> GetCategoryById(int id) 
        {
            var categorys = await _getCategorys();
            var category = new CategoryModel();
            foreach (var categ in categorys)
            {
                if (categ.Id == id)
                    category = categ;
            }
            return category;
        }
        private async Task<IList<CategoryModel>> _getCategorys()
        {
            try
            {
                string json = await _httpClientService.GetProductsAsync("category/tree/3/");
                var listCategory = (List<CategoryModel>)JsonConvert.DeserializeObject(json,
                    typeof(List<CategoryModel>));
                listCategory ??= new List<CategoryModel>();
                return listCategory;
            }
            catch (Exception ex)
            {
                return new List<CategoryModel>();
            }
        }
    }
}
