using OnlineRestaurantMenu.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class ProductType
    {
        public int Id { get; set; }
        public ProductTypeEnum Type { get; set; }
    }
}
