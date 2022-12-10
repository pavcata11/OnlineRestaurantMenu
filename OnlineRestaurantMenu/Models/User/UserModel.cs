using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OnlineRestaurantMenu.Models.User
{
    public class UserModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public IdentityRole? Role { get; set; }
        public List<IdentityRole> Roles { get; set; } = new List<IdentityRole>();
    }
}
