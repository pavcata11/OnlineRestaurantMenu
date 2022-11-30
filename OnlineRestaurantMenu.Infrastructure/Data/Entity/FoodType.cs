using System.ComponentModel.DataAnnotations;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.FoodType;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class FoodType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(FOOD_TYPE_NAME_MAX_LENGTH)]
        public string Type { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}
