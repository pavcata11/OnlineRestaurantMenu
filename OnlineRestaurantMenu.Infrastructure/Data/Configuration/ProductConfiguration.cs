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
                Image = "https://cdncloudcart.com/16474/products/images/2280/koka-kola-ken-330ml-image_5f5641fd58685_600x600.jpeg?1599488528",
                Price = 4,
                Calories = 200,
                TimeToget = 2,

            };
            products.Add(product);
            product = new Product()
            {
                Id = 2,
                ProductSecondaryTypeId = 1,
                Name = "Фанта портокал",
                Size = 250,
                Description = "Описание на фанта портокал някакъв текст",
                Image = "https://distribution-eu.com/wp-content/uploads/2021/05/Fanta-Orange.jpg",
                Price = 3,
                Calories = 80,
                TimeToget = 2,

            };
            products.Add(product);
            product = new Product()
            {
                Id = 3,
                ProductSecondaryTypeId = 5,
                Name = "Cappy праскова",
                Size = 250,
                Description = "Описание на Cappy праскова някакъв текст",
                Image = "https://bai-ilia.com/image/cache/data/kapi-praskova-0250l-kasa53-0-800x800.jpg",
                Price = 3,
                Calories = 192,
                TimeToget = 3,

            };
            product = new Product()
            {
                Id = 4,
                ProductSecondaryTypeId = 5,
                Name = "Cappy Вишна",
                Size = 250,
                Description = "Описание на Cappy Вишна някакъв текст",
                Image = "https://bai-ilia.com/image/cache/data/kapi-vishna-0250l-kasa55-0-800x800.jpg",
                Price = 3,
                Calories = 254,
                TimeToget = 3,
            };
            products.Add(product);
            product = new Product()
            {
                Id = 5,
                ProductSecondaryTypeId = 5,
                Name = "Cappy портокал",
                Size = 250,
                Description = "Описание на Cappy портокал някакъв текст",
                Image = "https://sofia.parkmart.bg/wp-content/uploads/2022/05/0000023548.jpg",
                Price = 3,
                Calories = 254,
                TimeToget = 3,

            };
            products.Add(product);
            product = new Product()
            {
                Id = 6,
                ProductSecondaryTypeId = 2,
                Name = "Овчарска салата",
                Size = 250,
                Description = "Описание на овчарска салата",
                Image = "https://gradcontent.com/lib/400x296/mozarella29.jpg",
                Price = 9.45m,
                Calories = 450,
                TimeToget = 32,

            };
            products.Add(product);
            product = new Product()
            {
                Id = 7,
                ProductSecondaryTypeId = 2,
                Name = "Салата Цезар",
                Size = 250,
                Description = "Описание на Цезар салата",
                Image = "https://matekitchen.com/wp-content/uploads/2021/12/salata-tsezar-s-pile-i-krutoni.jpg",
                Price = 9.45m,
                Calories = 450,
                TimeToget = 20,

            };
            products.Add(product);
            product = new Product()
            {
                Id = 8,
                ProductSecondaryTypeId = 2,
                Name = "Салата Цезар",
                Size = 250,
                Description = "Руска салата",
                Image = "https://www.supichka.com/files/images/2757/klasicheska_ruska_salata_1.jpg",
                Price = 9.45m,
                Calories = 450,
                TimeToget = 20,

            };
            products.Add(product);


            return products;
        }
    }
}