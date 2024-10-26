using GentlemenChoice_BAL.ModelView;
using GentlemenChoice_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice_BAL.Service.Interface
{
    public interface IProductService
    {
        Task<bool> AddNewProduct(Product product, List<string> imagePaths);

        Task<List<ProductDtoResponse>> GetAllProducts(int CategoryId);

        Task<ProductDtoResponse> GetProductByID(int id);

        Task<(bool check, List<string>? oldImagePaths)> UpdateProduct(ProductDtoRequest request, List<string> imagePaths, int id);

        Task<int> StatusProduct(int id);

        Task<List<ProductDtoResponse>> Search(string searchInput);

        Task<bool> DeleteProduct(int id);
    }
}
