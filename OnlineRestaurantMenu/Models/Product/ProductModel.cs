namespace OnlineRestaurantMenu.Models.Product
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }
        public int TimeToGet { get; set; }
        public string Image { get; set; }
        public int Size { get; set; }
        public int ProductTypeId { get; set; }
        public List<ProductTypesModel> ProductTypes { get; set; } = new List<ProductTypesModel>();

    }
}
