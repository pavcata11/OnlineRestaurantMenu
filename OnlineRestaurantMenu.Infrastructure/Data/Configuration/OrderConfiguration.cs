using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestaurantMenu.Infrastructure.Data.Configuration
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(ProductTypes());
        }

        private List<Order> ProductTypes()
        {
            var orders = new List<Order>();

            var order = new Order()
            {
                Id = 1,
                CallToWaiter= false,
                IsPay = false,
                TableId=1,
                UserId = "4b7f2886-0c38-41b3-8281-b6fc1f465838"
            };
            orders.Add(order);


            return orders;
        }
    }
}