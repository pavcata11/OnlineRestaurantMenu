using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineRestaurantMenu.Models
{
    public class MenuFoodModel
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; } = null!;
        public string Image { get; set; }

    }
}
