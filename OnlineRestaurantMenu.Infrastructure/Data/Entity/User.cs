using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.User;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class User: IdentityUser
    {
        [Required]
        [MaxLength(USER_FIRST_NAME_MAX_LENGTH)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(USER_LAST_NAME_MAX_LENGTH)]
        public string LastName { get; set; } = null!;
        public int Age { get; set; }


    }
}
