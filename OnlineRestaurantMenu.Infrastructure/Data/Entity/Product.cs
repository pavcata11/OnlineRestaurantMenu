using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class Product
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(ProductSecondaryTypeId))]
        public ProductSecondaryType ProductType { get; set; } = null!;
        [Required]
        public int ProductSecondaryTypeId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        [Required]
        public int Size { get; set; }
        [Required]
        public string Image { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Calories { get; set; }
        public int TimeToget { get; set; }
    }
}
