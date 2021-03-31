using BackEcommerceApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEcommerceApp.Interfaces
{
    public interface ICategoryService
    {
        Task<IList<CategoryModel>> GetCategorys();
        Task<CategoryModel> GetCategoryById(int id);
    }
}
