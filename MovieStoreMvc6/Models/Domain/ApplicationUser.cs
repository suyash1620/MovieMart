using Microsoft.AspNetCore.Identity;

namespace MovieStoreMvc6.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
