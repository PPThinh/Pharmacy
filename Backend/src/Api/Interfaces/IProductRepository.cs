using Api.Helpers;
using Api.Dtos.Product;
using Api.Models;

namespace Api.Interfaces
{
    public interface IProductRepository 
    {
        Task<List<Product>> GetAllAsync(ProductQueryObject query);
        Task<Product?> GetByIdAsync(int id);
        Task<Product?> CreateAsync(Product productModel);
        Task<Product?> UpdateAsync(int id, UpdateProductRequestDto productDto);
        Task<Product?> DeleteAsync(int id);
    }
}
