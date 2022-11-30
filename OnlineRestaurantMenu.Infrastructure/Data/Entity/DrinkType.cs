using System.ComponentModel.DataAnnotations;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class DrinkType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}
