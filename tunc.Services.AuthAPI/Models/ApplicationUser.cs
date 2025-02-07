using Microsoft.AspNetCore.Identity;

namespace tunc.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
