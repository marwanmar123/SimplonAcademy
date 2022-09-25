using Microsoft.AspNetCore.Identity;

namespace SimplonAcademy.Models
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
