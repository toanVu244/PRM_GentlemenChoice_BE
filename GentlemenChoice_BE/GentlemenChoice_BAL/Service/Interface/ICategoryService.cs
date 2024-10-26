using GentlemenChoice_BAL.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice_BAL.Service.Interface
{
    public interface ICategoryService
    {
        Task<List<CategoryDtoResponse>> GetAllCategories();
        Task<CategoryDtoResponse> GetCategoryById(int id);
        Task CreateCategory(CategoryDtoRequest request);
        Task UpdateCategory(int CategoryId, CategoryDtoRequest request);
        Task DeleteCategory(int CategoryId);
    }
}
