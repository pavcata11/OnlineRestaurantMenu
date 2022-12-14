using System.ComponentModel.DataAnnotations;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.Drink;
namespace OnlineRestaurantMenu.Models.Product
{
    public class AddProductModel 
    {
        [Required]
        [StringLength(DRINK_NAME_MAX_LENGTH, MinimumLength = DRINK_NAME_MIN_LENGTH)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(DRINK_DESCRIPTION_MAX_LENGTH, MinimumLength = DRINK_DESCRIPTION_MIN_LENGTH)]
        public string Description { get; set; } = null!;
        [Required]
        [Range(DRINK_CALORIES_MIN, DRINK_CALORIES_MAX)]
        public int Calories { get; set; }
        [Required]
        [Range(DRINK_PRICE_MIN, DRINK_PRICE_MAX)]
        public decimal Price { get; set; }
        [Required]
        [Range(DRINK_SIZE_MIN, DRINK_SIZE_MAX)]
        public int Size { get; set; }
        [Required]
        [StringLength(DRINK_IMAGE_MAX_LENGTH, MinimumLength = DRINK_IMAGE_MIN_LENGTH)]
        public string Image { get; set; } = null!;
        [Required]
        public int TimeToGet { get; set; }
        public int ProductTypeId { get; set; }
        public List<ProductTypesModel> ProductTypes { get; set; } = new List<ProductTypesModel>();


    }
   
}
