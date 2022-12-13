using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;

namespace OnlineRestaurantMenu.Infrastructure.Data.Configuration
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(CreateOrder());
        }

        private List<Order> CreateOrder()
        {
            var orders = new List<Order>();
            var drinks = new List<Drink>();


            var order = new Order()
            {
                Id = 1,
                UserId = "635a6ee6-f1de-4ce5-af5e-5af83b6d307d",
                Drinks = new List<Drink>()
                {
                    new Drink()
                    {
                        Id = 6,
                        Name = "Фанта Горски плод",
                        Description = "Фанта Горски плод е плодова газирана напитка, която създава страхотен бълбукащ вкус в устата през моментите на забавление с приятели. Освежаващите балончета на Fanta предизвикват сетивата по уникално приятен начин.",
                        Size = 250,
                        Image = "https://www.ebag.bg/products/images/88489/800",
                        Price = 2,
                        Calories = 250,
                        DrinkTyepeId = 1,
                       
                    },
                },
                Foods= new List<Foods>(),
                IsPay = false,
                CallToWaiter = false,
            };
            orders.Add(order);

            return orders;
        }
    }
}
