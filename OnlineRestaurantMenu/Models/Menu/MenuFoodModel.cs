using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.FoodType;

namespace OnlineRestaurantMenu.Models.Menu
{
    public class MenuFoodModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(FOOD_TYPE_NAME_MAX_LENGTH, MinimumLength = FOOD_TYPE_NAME_MIN_LENGTH)]
        public string Type { get; set; } = null!;
        [Required]
        [StringLength(FOOD_TYPE_IMAGE_MAX_LENGTH, MinimumLength = FOOD_TYPE_IMAGE_MIN_LENGTH)]
        public string Image { get; set; } = null!;

    }
}
