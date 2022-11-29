using System.ComponentModel.DataAnnotations;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants.Cafe;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class Cafe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(COFE_NAME_MAX_LENGTH)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(OWNER_FIRST_NAME_MAX_LENGTH)]
        public string OwnerFirstName { get; set; } = null!;
        [Required]
        [MaxLength(OWNER_SECOND_NAME_MAX_LENGTH)]
        public string OwnerSecondName { get; set; } = null!;
        [Required]
        [MaxLength(OWNER_LAST_NAME_MAX_LENGTH)]
        public string OwnerLastName { get; set; } = null!;
        public List<Table> Tables { get; set; } = new List<Table> ();
        public List<Drink> Drinks { get; set; } = new List<Drink> ();
        public List<Foods> Foods { get; set; } = new List<Foods> ();


    }
}
