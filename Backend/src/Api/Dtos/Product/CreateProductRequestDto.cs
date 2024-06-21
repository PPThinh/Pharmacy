using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Api.Dtos.Product
{
    public class CreateProductRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public int Price { get; set; }
        //public string ImagePath {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
