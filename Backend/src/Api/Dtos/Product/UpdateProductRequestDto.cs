using Microsoft.AspNetCore.Mvc;

namespace Api.Dtos.Product
{
    public class UpdateProductRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public int Price { get; set; }
        //public string ImagePath {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
