using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MinLength(9)]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        // quận
        public string District { get; set; }
        // phường
        public string Ward { get; set; }
        public string Street { get; set; }
        public List<Order> Orders { get; set; }

    }
}
