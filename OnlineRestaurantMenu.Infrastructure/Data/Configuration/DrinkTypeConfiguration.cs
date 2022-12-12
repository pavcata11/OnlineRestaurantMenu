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
                Image = "https://raffyplovdiv.bg/files/images/749/fit_536_406.jpg"
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
                Id = 2,
                Type = "Фрешове",
                Image = "https://cache2.24chasa.bg/Images/cache/281/Image_6207281_128_0.jpg"
            };
            drinkTypes.Add(type);
            type = new DrinkType()
            {
                Id = 2,
                Type = "Кафета",
                Image = "https://cdn4.focus.bg/fakti/photos/original/8ac/zdravoslovno-e-da-piem-po-6-ili-7-kafeta-na-den-6.jpg"
            };

            drinkTypes.Add(type);

            return drinkTypes;
        }
    }
}
