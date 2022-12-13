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
                UserId = "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                DateStartWork = DateTime.Now,
            };
            waiters.Add(waiter);
            return waiters;
        }
    }
}
