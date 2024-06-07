using Pharmacy.Api.Dtos.Product;
using Pharmacy.Api.Models;
namespace Pharmacy.Api.Mappers
{
    public static class ProductMappers
    {
        // anh xa tu thuc the product
        public static ProductDto ToProductDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                CompanyName = product.CompanyName,
                Price = product.Price
            };
        }

        public static Product ToProductFromCreateDto(this CreateProductRequestDto productDto)
        {
            return new Product
            {
                Name = productDto.Name,
                CompanyName = productDto.CompanyName,
                Price = productDto.Price,
                Description = productDto.Description
            };
        }
    }
}
