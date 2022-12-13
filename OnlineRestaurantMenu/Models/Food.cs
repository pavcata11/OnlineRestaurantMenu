namespace OnlineRestaurantMenu.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }
        public int TimeToGet { get; set; }
        public string Image { get; set; }
        public int  Size { get; set; }

    }
}
