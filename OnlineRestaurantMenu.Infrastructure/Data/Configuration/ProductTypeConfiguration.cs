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
    internal class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasData(ProductTypes());
        }

        private List<ProductType> ProductTypes()
        {
            var productTypes = new List<ProductType>();

            var productType = new ProductType()
            {
                Id = 1,
                Type = Enums.ProductTypeEnum.Храни,
            };
            productTypes.Add(productType);
            productType = new ProductType()
            {
                Id = 2,
                Type = Enums.ProductTypeEnum.Напитки,
            };
            productTypes.Add(productType);

            return productTypes;
        }
    }
}
