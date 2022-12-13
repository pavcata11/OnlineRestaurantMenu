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
    internal class FoodTypeConfiguration : IEntityTypeConfiguration<FoodType>
    {
        public void Configure(EntityTypeBuilder<FoodType> builder)
        {
            builder.HasData(CreateFoodTypes());
        }

        private List<FoodType> CreateFoodTypes()
        {
            var foodTypes = new List<FoodType>();

            var type = new FoodType()
            {
                Id = 1,
                Type = "Салати",
                Image = "https://domashnakunyasdani.com/wp-content/uploads/2022/06/snapshot448.jpg"
            };
            foodTypes.Add(type);
            type = new FoodType()
            {
                Id = 2,
                Type = "Основни ястия",
                Image = "http://mirenaancheva.com/zashtone/wp-content/uploads/sites/2/2019/02/IMG_1232.jpg"
            };
            foodTypes.Add(type);
            type = new FoodType()
            {
                Id = 3,
                Type = "Супи",
                Image = "https://domashnakunyasdani.com/wp-content/uploads/2022/05/snapshot34.jpg"
            };
            foodTypes.Add(type);

            return foodTypes;
        }
    }
}
