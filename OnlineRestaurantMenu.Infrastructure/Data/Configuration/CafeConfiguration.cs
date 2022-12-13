using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRestaurantMenu.Infrastructure.Data.Configuration
{
    internal class CafeConfiguration : IEntityTypeConfiguration<Cafe>
    {
        public void Configure(EntityTypeBuilder<Cafe> builder)
        {
            builder.HasData(CreateCafe());
        }

        private List<Cafe> CreateCafe()
        {
            var allCafe = new List<Cafe>();

            var cafe = new Cafe()
            {
                Id = 1,
                Name ="Трите Щерки",
                OwnerFirstName = "Павел",
                OwnerSecondName="Даниелов",
                OwnerLastName = "Иванчев",
            };
            allCafe.Add(cafe);
           
            return allCafe;
        }
    }
}
