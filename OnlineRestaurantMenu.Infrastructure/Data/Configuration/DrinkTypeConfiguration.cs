using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;

namespace OnlineRestaurantMenu.Infrastructure.Data.Configuration
{
    internal class DrinkTypeConfiguration : IEntityTypeConfiguration<DrinkType>
    {
        public void Configure(EntityTypeBuilder<DrinkType> builder)
        {
            builder.HasData(CreateDrinkTypes());
        }

        private List<DrinkType> CreateDrinkTypes()
        {
            var drinkTypes = new List<DrinkType>();

            var type = new DrinkType()
            {
                Id = 1,
                Type = "Безалкохолни",
                Image = "https://www.foodbusinessafrica.com/wp-content/uploads/2021/08/soda.jpg"
            };
            drinkTypes.Add(type);
            type = new DrinkType()
            {
                Id = 2,
                Type = "Сокове",
                Image = "https://gornabania.com/media/k2/items/cache/3b77d3f73b59742412f393cd0d264b14_M.jpg"
            };
            drinkTypes.Add(type);
            type = new DrinkType()
            {
                Id = 3,
                Type = "Фрешове",
                Image = "https://cache2.24chasa.bg/Images/cache/281/Image_6207281_128_0.jpg"
            };
            drinkTypes.Add(type);
           

            return drinkTypes;
        }
    }
}
