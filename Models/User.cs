using Microsoft.AspNetCore.Identity;

namespace EcommerceMVC.Models
{
    public class User : IdentityUser
    {
        // Add additional properties if needed
        public string ? FirstName { get; set; } 
        public string ? LastName { get; set; }
    }
}