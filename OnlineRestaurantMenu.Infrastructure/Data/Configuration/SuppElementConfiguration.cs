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
    internal class SuppElementConfiguration : IEntityTypeConfiguration<Supplements>
    {
        public void Configure(EntityTypeBuilder<Supplements> builder)
        {
            builder.HasData(CreateSuppElemets());
        }

        private List<Supplements> CreateSuppElemets()
        {
            var supplements = new List<Supplements>();

            var supplement = new Supplements()
            {
                Id = 1,
                Name = "Захар",
                Price = 1
            };
            supplements.Add(supplement);
            supplement = new Supplements()
            {
                Id = 2,
                Name = "Лимон",
                Price = 1
            };
            supplements.Add(supplement);
            supplement = new Supplements()
             {
                 Id = 3,
                 Name = "Мед",
                 Price = 1
             };
            supplements.Add(supplement);

            return supplements;
        }
    }
}