using Microsoft.AspNetCore.Identity;

namespace SchoolManagementSystem.Models
{
    public class User:IdentityUser
    {
        public UserType UserType { get; set; }
    }
}
