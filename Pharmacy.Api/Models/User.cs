using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Api.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;
        
        public Role Role { get; set; }
        
        public string Email { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;
        
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
