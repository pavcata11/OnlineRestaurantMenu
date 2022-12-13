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
    internal class TableConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.HasData(CreateTables());
        }

        private List<Table> CreateTables()
        {
            var tables = new List<Table>();

            var table = new Table()
            {
                Id = 1,
                Description = "Масата се намира на до прозореца",
                TableStatus = Enums.TableStatus.Свободна,
                CountOfSeats = 4,
                Number = 1,
                WaiterId = 1,
            };
            tables.Add(table);
            table = new Table()
            {
                Id = 1,
                Description = "Втората маса до прозореца",
                TableStatus = Enums.TableStatus.Свободна,
                CountOfSeats = 5,
                Number = 2,
                WaiterId = 1,
            };
            tables.Add(table);
            table = new Table()
            {
                Id = 1,
                Description = "Централната маса в първа зала",
                TableStatus = Enums.TableStatus.Свободна,
                CountOfSeats = 10,
                Number = 3,
                WaiterId = 1,
            };
            tables.Add(table);


            return tables;
        }
    }
}
