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
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(ProductTypes());
        }

        private List<Product> ProductTypes()
        {
            var products = new List<Product>();

            var product = new Product()
            {
                Id = 1,
                ProductSecondaryTypeId = 1,
                Name = "Кока-кола",
                Size = 250,
                Description = "Описание на кока-кола някакъв текст",
                Image = "https://www.foodbusinessafrica.com/wp-content/uploads/2021/08/soda.jpg",
                Price = 4,
                Calories = 200,
                TimeToget = 2,

            };
            products.Add(product);
            product = new Product()
            {
                Id = 2,
                ProductSecondaryTypeId = 2,
                Name = "Овчарска салата",
                Size = 250,
                Description = "Описание на овчарска салата",
                Image = "https://www.foodbusinessafrica.com/wp-content/uploads/2021/08/soda.jpg",
                Price = 9.45m,
                Calories = 450,
                TimeToget = 2,

            };
            products.Add(product);


            return products;
        }
    }
}