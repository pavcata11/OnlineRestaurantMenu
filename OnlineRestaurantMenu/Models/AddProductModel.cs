namespace OnlineRestaurantMenu.Models
{
    public class AddProductModel
    {
        public string Name { get; set; } = null!;
        public int TimeToGet { get; set; }
        public int Size { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int TypeId { get; set; }
        public string Image { get; set; }
        public IEnumerable<DrinkTypesModel> FoodType { get; set; } = new List<DrinkTypesModel>();
    }
}
