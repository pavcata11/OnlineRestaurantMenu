using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class ProductSecondaryType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int ProductTypeId { get; set; }
        [Required]
        [ForeignKey(nameof(ProductTypeId))]
        public ProductType ProductType { get; set; }
    }
}
