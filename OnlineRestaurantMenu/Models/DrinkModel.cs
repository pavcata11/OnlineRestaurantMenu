using OnlineRestaurantMenu.Infrastructure.Data.Enums;
using OnlineRestaurantMenu.Models.Product;
using System.ComponentModel.DataAnnotations;

namespace OnlineRestaurantMenu.Models
{
    public class DrinkModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string Image { get; set; }
      
        public int TypeId { get; set; }

        public IEnumerable<ProductTypesModel> DrinkTypes { get; set; } = new List<ProductTypesModel>();

        [Required]
        public int Id { get; set; }
      
    }
}
