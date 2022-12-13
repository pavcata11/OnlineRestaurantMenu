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
    internal class WaiterConfiguration : IEntityTypeConfiguration<Waiter>
    {
        public void Configure(EntityTypeBuilder<Waiter> builder)
        {
            builder.HasData(CreateWaiters());
        }

        private List<Waiter> CreateWaiters()
        {
            var waiters = new List<Waiter>();

            var waiter = new Waiter()
            {
                Id = 1,
                UserId = "dea12856-c198-4129-b3f3-b893d8395082",
                DateStartWork = DateTime.Now,
            };
            waiters.Add(waiter);
            waiter = new Waiter()
            {
                Id = 2,
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                DateStartWork = DateTime.Now,
            };
            waiters.Add(waiter);
            waiter = new Waiter()
            {
                Id = 3,
                UserId = "cab25823-7170-4e85-96b8-ac84c7acf0c7",
                DateStartWork = DateTime.Now,
            };
            waiters.Add(waiter);

            return waiters;
        }
    }
}
