using BackEcommerceApp.Interfaces;
using BackEcommerceApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEcommerceApp.Pages
{
    public class IndexModel : PageModel
    {
        public CategoryModel Categorys { get; set; }
            = new CategoryModel();
        
        private readonly ILogger<IndexModel> _logger;
        private readonly ICategoryService _categoryService;
        public IndexModel(ILogger<IndexModel> logger, 
            ICategoryService categoryService, 
            IProductsService productsService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        public async Task OnGetAsync()
        {
            Categorys = await _categoryService.GetCategoryById(1);
        }
    }
}
