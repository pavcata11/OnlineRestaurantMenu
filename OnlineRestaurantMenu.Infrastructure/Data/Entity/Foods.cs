using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.Food;
namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class Foods
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(FOOD_NAME_MAX_LENGTH)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(FOOD_DESCRIPTION_MAX_LENGTH)]
        public string Description { get; set; } = null!;
        [Required]
        public int Size { get; set; } 
        [Required]
        [MaxLength(FOOD_IMAGE_MAX_LENGTH)]
        public string Image { get; set; } = null!;
        [Required]
        public int CookingTime { get; set; }
        [Required]
        public int Calories { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [ForeignKey(nameof(TypeId))]
        public FoodType Type { get; set; } = null!;
        [Required]
        public int TypeId { get; set; }

    }
}
