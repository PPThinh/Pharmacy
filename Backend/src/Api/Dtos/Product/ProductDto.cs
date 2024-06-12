using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Api.Dtos.Product
{
    public class ProductDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        public int Price { get; set; }
    }
}
