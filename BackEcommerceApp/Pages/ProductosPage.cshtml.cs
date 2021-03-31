using BackEcommerceApp.Interfaces;
using BackEcommerceApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BackEcommerceApp.Pages
{

    public class ProductosPageModel : PageModel
    {
        public IList<ProductsModelClean> Productos { get; set; }
                = new List<ProductsModelClean>();
        private readonly IProductsService _productsService;
        public ProductosPageModel(IProductsService productsService)
        {
            _productsService = productsService;
        }
        public async Task OnGetAsync()
        {
            var resultResult = await _productsService.GetProducts();
            foreach (var product in resultResult)
            {
                var producto = new ProductsModelClean 
                {
                    Description = product.MetaTagDescription,
                    Name = product.ProductName,
                    TItle = product.ProductTitle
                };
                product.Items.ForEach(x=> 
                {
                    x.Images.ForEach(i => producto.ImageUrl = i.ImageUrl.ToString());
                    x.Sellers.ForEach(s => producto.Price = s.CommertialOffer.Price);
                });
                Productos.Add(producto);
            }
        }
    }
}
