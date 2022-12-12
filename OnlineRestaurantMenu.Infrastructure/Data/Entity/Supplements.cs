using System.ComponentModel.DataAnnotations;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.Supplements;


namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class Supplements
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(SUPPELEMENT_NAME_MAX_LENGTH)]
        public string Name { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
    }
}
