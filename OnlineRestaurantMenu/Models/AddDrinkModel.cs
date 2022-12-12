using Humanizer.Localisation;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Infrastructure.Data.Enums;

namespace OnlineRestaurantMenu.Models
{
    public class AddDrinkModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string Image { get; set; }
        public DrinkMainTypes DrinkMainType { get; set; }
        public int TypeId { get; set; }
        public IEnumerable<DrinkTypesModel> DrinkTypes { get; set; } = new List<DrinkTypesModel>();


        public SingleFileModel File { get; set; }
    }
}
