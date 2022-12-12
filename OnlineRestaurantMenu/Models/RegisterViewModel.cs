using System.ComponentModel.DataAnnotations;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.User;
namespace OnlineRestaurantMenu.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(USER_FIRST_NAME_MAX_LENGTH, MinimumLength = USER_FIRST_NAME_MIN_LENGTH)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(USER_LAST_NAME_MAX_LENGTH, MinimumLength = USER_LAST_NAME_MIN_LENGTH)]
        public string LastName { get; set; } = null!;
        [Required]
        [StringLength(UserUsernameMaxLength, MinimumLength = UserUsernameMinLength)]
        public string UserName { get; set; } = null!;
        [Required]
        [StringLength(UserEmailMaxLength, MinimumLength = UserEmailMinLength)]
        public string Email { get; set; } = null!;
        [Required]
        [StringLength(UserPasswordMaxLength, MinimumLength = UserPasswordMinLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;

    }
}
