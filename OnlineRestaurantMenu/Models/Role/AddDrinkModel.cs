using Humanizer.Localisation;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.Drink;
namespace OnlineRestaurantMenu.Models.Role
{
    public class AddDrinkModel
    {
        [Required]
        [StringLength(DRINK_NAME_MAX_LENGTH, MinimumLength = DRINK_NAME_MIN_LENGTH)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(DRINK_DESCRIPTION_MAX_LENGTH, MinimumLength = DRINK_DESCRIPTION_MIN_LENGTH)]
        public string Description { get; set; } = null!;
        [Required]
        public int Calories { get; set; }
        [Required]
        [Range(DRINK_PRICE_MAX, DRINK_PRICE_MIN)]
        public decimal Price { get; set; }
        [Required]
        [Range(DRINK_SIZE_MAX, DRINK_SIZE_MIN)]
        public int Size { get; set; }
        [Required]
        [StringLength(DRINK_IMAGE_MAX_LENGTH, MinimumLength = DRINK_IMAGE_MIN_LENGTH)]
        public string Image { get; set; } = null!;
        [Required]
        public int TypeId { get; set; }
        public IEnumerable<DrinkTypesModel> DrinkTypes { get; set; } = new List<DrinkTypesModel>();
        [Required]
        public Product.AddDrinkModel File { get; set; } = null!;
    }
}
