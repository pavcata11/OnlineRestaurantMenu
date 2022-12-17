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
    internal class ProductSecondaryTypeConfiguration : IEntityTypeConfiguration<ProductSecondaryType>
    {
        public void Configure(EntityTypeBuilder<ProductSecondaryType> builder)
        {
            builder.HasData(CreateProductSecondaryType());
        }

        private List<ProductSecondaryType> CreateProductSecondaryType()
        {
            var productSecondaryTypes = new List<ProductSecondaryType>();

            var productSecondaryType = new ProductSecondaryType()
            {
                Id = 1,
                Name = "Безалкохолни",
                Image = "https://www.foodbusinessafrica.com/wp-content/uploads/2021/08/soda.jpg",
                ProductTypeId= 1, 
            };
            productSecondaryTypes.Add(productSecondaryType);
            productSecondaryType = new ProductSecondaryType()
            {
                Id = 2,
                Name = "Салати",
                Image = "https://www.acouplecooks.com/wp-content/uploads/2019/05/Chopped-Salad-001_1.jpg",
                ProductTypeId = 2,
            };
            productSecondaryTypes.Add(productSecondaryType);
            productSecondaryType = new ProductSecondaryType()
            {
                Id = 3,
                Name = "Основни ястия",
                Image = "https://raffyplovdiv.bg/files/images/578/fit_536_406.jpg",
                ProductTypeId = 2,
            };
            productSecondaryTypes.Add(productSecondaryType);
            productSecondaryType = new ProductSecondaryType()
            {
                Id = 4,
                Name = "Супи",
                Image = "https://s.rozali.com/p/k/r/krem-supa-254088-500x0.jpg?1475569614483",
                ProductTypeId = 2,
            };
            productSecondaryTypes.Add(productSecondaryType);
            productSecondaryType = new ProductSecondaryType()
            {
                Id = 5,
                Name = "Сокове",
                Image = "https://m.netinfo.bg/media/images/32836/32836858/991-ratio-sok-plodov-sok.jpg",
                ProductTypeId = 1,
            };
            productSecondaryTypes.Add(productSecondaryType);
            productSecondaryType = new ProductSecondaryType()
            {
                Id = 6,
                Name = "Фрешове",
                Image = "https://cache2.24chasa.bg/Images/cache/281/Image_6207281_128_0.jpg",
                ProductTypeId = 1,
            };
            productSecondaryTypes.Add(productSecondaryType);


            return productSecondaryTypes;
        }
    }
}