using BackEcommerceApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEcommerceApp.Interfaces
{
    public interface IProductsService
    {
        Task<IList<ProductsModel>> GetProducts();
    }
}