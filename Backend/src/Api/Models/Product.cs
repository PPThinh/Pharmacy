using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        public int Price { get; set; }
        //public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
