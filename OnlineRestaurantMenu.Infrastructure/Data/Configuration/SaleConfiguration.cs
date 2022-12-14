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
    internal class SaleConfiguration : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder.HasData(ProductTypes());
        }

        private List<Sales> ProductTypes()
        {
            var sales = new List<Sales>();

            var sale = new Sales()
            {
                Id = 1,
                CountOfSalesThisItem=5,
                ProductId=1,
                OrderId=1,
            };
            sales.Add(sale);


            return sales;
        }
    }
}
