using Microsoft.AspNetCore.Identity;
namespace E_Commerce.API.Models
{
    public abstract class User : IdentityUser
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Optional: common methods
        public abstract string GetRole();
    }
}
