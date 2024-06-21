using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class User : IdentityUser
    {   
        public Employee Employee { get; set; }
        //public string Name { get; set; } = string.Empty;
        //public string Address { get; set; } = string.Empty;
    }
}
