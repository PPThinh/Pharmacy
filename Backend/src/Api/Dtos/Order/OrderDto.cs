using Api.Models;
using System.ComponentModel.DataAnnotations;

namespace Api.Dtos.Order
{
    public class OrderDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public string CustomerPhoneNumber { get; set; } = string.Empty;
        [Required]
        public string EmployeeName { get; set; } = string.Empty;
        [Required]
        public string StoreName { get; set; } = string.Empty;
    }
}
