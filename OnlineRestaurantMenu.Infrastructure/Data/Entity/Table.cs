using OnlineRestaurantMenu.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.Table;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(TABLE_DESCRIPTION_MAX_LENGTH)]
        public string Description { get; set; } = null!;
        public TableStatus TableStatus { get; set; }
        [Required]
        public int CountOfSeats { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        [ForeignKey(nameof(WaiterId))]
        public Waiter Waiter { get; set; }
        public int WaiterId { get; set; }

    }
}
