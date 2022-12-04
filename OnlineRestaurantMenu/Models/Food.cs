namespace OnlineRestaurantMenu.Models
{
    public class Food
    {
        public string Name { get; set; } = null!;
        public int TimeToGet { get; set; }
        public int Size { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
