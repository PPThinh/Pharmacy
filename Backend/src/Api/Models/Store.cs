using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Api.Models
{
    public class Store
    {
        [Required]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
