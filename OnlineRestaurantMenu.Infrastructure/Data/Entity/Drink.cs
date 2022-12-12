using OnlineRestaurantMenu.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.Drink;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class Drink
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(DrinkTyepeId))]
        public DrinkType Type { get; set; } = null!;

        [Required]
        public int DrinkTyepeId { get; set; }

        [Required]
        [MaxLength(DRINK_NAME_MAX_LENGTH)]
        public string Name { get; set; } = null!;

        [MaxLength(DRINK_DESCRIPTION_MAX_LENGTH)]
        public string Description { get; set; } = null!;

        [Required]
        public int Size { get; set; }

        [Required]
        [MaxLength(DRINK_IMAGE_MAX_LENGTH)]
        public string Image { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Calories { get; set; }
    }
}
