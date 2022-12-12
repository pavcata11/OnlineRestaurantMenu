using System.ComponentModel.DataAnnotations;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.DrinkType;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class DrinkType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(DRINK_TYPE_NAME_MAX_LENGTH)]
        public string Type { get; set; } = null!;
        [Required]
        [MaxLength(DRINK_TYPE_IMAGE_MAX_LENGTH)]
        public string Image { get; set; } = null!;
    }
}
