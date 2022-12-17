using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineRestaurantMenu.Models.Product
{
    public class TableModel
    {
        
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        public TableStatus TableStatus { get; set; }
        public int CountOfSeats { get; set; }
        public int Number { get; set; }
  
    }
}
