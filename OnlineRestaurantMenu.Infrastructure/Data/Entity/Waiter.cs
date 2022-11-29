using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class Waiter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Egn { get; set; }
        [Required]
        public DateTime DateStartWork { get; set; }

    }
}
