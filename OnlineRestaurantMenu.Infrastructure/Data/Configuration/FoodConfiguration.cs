﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;

namespace OnlineRestaurantMenu.Infrastructure.Data.Configuration
{
    internal class FoodConfiguration : IEntityTypeConfiguration<Foods>
    {
        public void Configure(EntityTypeBuilder<Foods> builder)
        {
            builder.HasData(CreateDrinks());
        }

        private List<Foods> CreateDrinks()
        {
            var foods = new List<Foods>();

            var food = new Foods()
            {
                Id = 1,
                Name = "Овчарска салат",
                Description = "Овчарската салата е традиционно българско ястие и модификация на шопската салата. Приготвя се от нарязани краставици, домати, лук, магданоз, печени или сурови чушки, шунка, сварено яйце, кашкавал, настъргано бяло саламурено сирене и овкусени със сол и олио.",
                Size=250,
                Image = "http://birariakedara.com/wp-content/uploads/2015/10/%D0%BE%D0%B2%D1%87%D0%B0%D1%80%D1%81%D0%BA%D0%B0.jpg",
                Price = 3,
                Calories = 80,
                CookingTime=45,
                TypeId = 1,
            };
            foods.Add(food);
            food = new Foods()
            {
                Id = 2,
                Name = "Салата Цезар",
                Description = "Салата „Цезар“ е популярна салата от маруля и крутони, гарнирани с пармезан, лимонов сок, зехтин, яйце, черен пипер и сос Уорчестър.",
                Size = 250,
                Image = "https://matekitchen.com/wp-content/uploads/2021/12/salata-tsezar-s-pile-i-krutoni.jpg",
                Price = 3,
                Calories = 80,
                CookingTime = 45,
                TypeId = 1,
            };
            foods.Add(food);
            food = new Foods()
            {
                Id = 3,
                Name = "Мусака",
                Description = "Мусака! Царицата на българската кухня! Едно от най-обичаните и най-често приготвяните ястия. Мусаката е абсолютният любимец както на всеки българин, така и на чужденците.",
                Size = 250,
                Image = "https://www.supichka.com/files/images/1242/fit_1400_933.jpg",
                Price = 3,
                Calories = 80,
                CookingTime = 45,
                TypeId = 2,
            };
            foods.Add(food);
            food = new Foods()
            {
                Id = 4,
                Name = "Боб с карначета",
                Description = "Боб и карначета - перфектната комбинация за едно вкусно похапване",
                Size = 250,
                Image = "https://m.1001recepti.com/images/photos/recipes/size_5/pechen-bob-ot-konserva-v-glinen-sud-s-nadenichki-1-[3573].jpg",
                Price = 3,
                Calories = 80,
                CookingTime = 45,
                TypeId = 3,
            };
            foods.Add(food);

            return foods;
        }
    }
}