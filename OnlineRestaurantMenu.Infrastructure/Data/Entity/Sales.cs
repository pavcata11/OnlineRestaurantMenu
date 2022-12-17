using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class Sales
    {
        public int Id { get; set; }
        public int CountOfSalesThisItem { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
