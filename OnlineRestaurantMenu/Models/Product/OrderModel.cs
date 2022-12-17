using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OnlineRestaurantMenu.Models.Product
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }
        public int TimeToGet { get; set; }
        public string Image { get; set; }
        public int Size { get; set; }
        public int Count { get; set; } = 0;
        public int TableId { get; set; }
        public IEnumerable<TableModel> OrderTables { get; set; } = new List<TableModel>();

    }
}
