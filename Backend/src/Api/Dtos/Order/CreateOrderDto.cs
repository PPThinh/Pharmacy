using Api.Models;
using System.ComponentModel.DataAnnotations;

namespace Api.Dtos.Order
{
    public class CreateOrderDto
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [MinLength(9)]
        [MaxLength(12)]
        public string CustomerPhoneNumber { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
