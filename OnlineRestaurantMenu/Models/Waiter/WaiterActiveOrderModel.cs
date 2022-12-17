using OnlineRestaurantMenu.Models.Product;

namespace OnlineRestaurantMenu.Models.Waiter
{
    public class WaiterActiveOrderModel
    {
        public int Id { get; set; }
        public List<ProductModel> Products { get; set; } = new List<ProductModel>();
        public Boolean ComoOnWaiter { get; set; }
        public double Price { get; set; }
        public bool OrderStatus { get; set; }
        
       
    }
}
