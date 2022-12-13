using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;

namespace OnlineRestaurantMenu.Infrastructure.Data.Configuration
{
    internal class DrinkConfiguration : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.HasData(CreateDrinks());
        }

        private List<Drink> CreateDrinks()
        {
            var drinks = new List<Drink>();

            var drink = new Drink()
            {
                Id = 1,
                Name = "Кока-кола",
                Description = "Ко̀ка-ко̀ла е популярна газирана безалкохолна напитка, предлагана по целия свят, една от най-известните и продавани търговски марки в света. Известна е още със съкратеното разговорно наименование ко̀ла.",
                Size=250,
                Image = "https://www.fastbag.bg/wp-content/uploads/2020/07/coca-cola-2l-original.jpeg",
                Price = 3,
                Calories = 80,
                DrinkTyepeId = 1,
            };
            drinks.Add(drink);
            drink = new Drink()
            {
                Id = 2,
                Name = "Фанта Портокал",
                Description = "Фанта портокал е плодова газирана напитка, която създава страхотен бълбукащ вкус в устата през моментите на забавление с приятели. Освежаващите балончета на Fanta предизвикват сетивата по уникално приятен начин.",
                Size = 250,
                Image = "https://napitkite.bg/wp-content/uploads/2018/04/fanta-portokal-ken.png",
                Price = 5,
                Calories = 145,
                DrinkTyepeId = 1,
            };
            drinks.Add(drink);
            drink = new Drink()
            {
                Id = 3,
                Name = "Фанта Лимон",
                Description = "Фанта лимон е плодова газирана напитка, която създава страхотен бълбукащ вкус в устата през моментите на забавление с приятели. Освежаващите балончета на Fanta предизвикват сетивата по уникално приятен начин.",
                Size = 250,
                Image = "https://napitkite.bg/wp-content/uploads/2018/04/fanta-portokal-ken.png",
                Price = 2,
                Calories = 250,
                DrinkTyepeId = 1,
            };
            drinks.Add(drink);
            drink = new Drink()
            {
                Id = 4,
                Name = "Cappy Праскова",
                Description = "Освежаваща негазирана плодова напитка с пюре от праскова. От концентрат. Плодово съдържание мин. 42%.\r\nПастьоризиран продукт. Не съдържа консерванти.",
                Size = 1000,
                Image = "https://randi.bg/image/cache/catalog/Produkti-nov/Bezalkoholni/sokove/cappy-praskova-1l-600x600.jpg",
                Price = 4,
                Calories = 400,
                DrinkTyepeId = 2,
            };
            drinks.Add(drink);
            drink = new Drink()
            {
                Id = 5,
                Name = "Cappy Портокал",
                Description = "Cappy създава изключително вкусни сокове, нектари и плодови напитки вече над 60 години и вярваме, че прекрасният вкус на плодовете може да бъде източник на удоволствие и наслада всеки ден.",
                Size = 1000,
                Image = "https://gofood.bg/wp-content/uploads/2020/07/cappy9.jpg",
                Price = 4,
                Calories = 90,
                DrinkTyepeId = 2,
            };
            drinks.Add(drink);
            drink = new Drink()
            {
                Id = 6,
                Name = "Cappy Вишна",
                Description = "Освежаваща негазирана плодова напитка с пюре от вишни. От концентрат. Плодово съдържание мин. 42%.\r\nПастьоризиран продукт. Не съдържа консерванти.",
                Size = 1000,
                Image = "https://kancelarski.bg/userfiles/productlargeimages/product_31162.jpg",
                Price = 3,
                Calories = 120,
                DrinkTyepeId = 2,
            };
            drinks.Add(drink);



            return drinks;
        }
    }
}
