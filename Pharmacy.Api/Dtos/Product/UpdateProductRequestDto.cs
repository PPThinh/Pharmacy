using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Api.Dtos.Product
{
    public class UpdateProductRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public int Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
