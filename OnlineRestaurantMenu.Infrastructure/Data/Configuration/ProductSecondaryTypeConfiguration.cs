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
                Image = "https://www.foodbusinessafrica.com/wp-content/uploads/2021/08/soda.jpg",
                ProductTypeId = 2,
            };
            productSecondaryTypes.Add(productSecondaryType);


            return productSecondaryTypes;
        }
    }
}