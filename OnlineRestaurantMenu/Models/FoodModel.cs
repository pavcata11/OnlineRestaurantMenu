using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models.Product;
using System.ComponentModel.DataAnnotations;

namespace OnlineRestaurantMenu.Models
{
    public class FoodModel
    {
        public string Name { get; set; } = null!;
        public int TimeToGet { get; set; }
        public int Size { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int TypeId { get; set; }
        public string Image { get; set; }

        public IEnumerable<ProductTypesModel> FoodType { get; set; } = new List<ProductTypesModel>();

        [Required]
        public int Id { get; set; }
    }
}
