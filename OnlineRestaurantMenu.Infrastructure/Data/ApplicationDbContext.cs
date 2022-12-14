using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Infrastructure.Data.Configuration;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OnlineRestaurantMenu.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
     
    

    protected override void OnModelCreating(ModelBuilder builder)
        {
         

            builder.ApplyConfiguration(new ProductTypeConfiguration());
            builder.ApplyConfiguration(new ProductSecondaryTypeConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(builder);
            this.SeedRoles(builder);
            this.SeedUsers(builder);
            this.SeedUserRoles(builder);
            builder.ApplyConfiguration(new WaiterConfiguration());
            builder.ApplyConfiguration(new TableConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new SaleConfiguration());


        }

        private void SeedUsers(ModelBuilder builder)
        {
            User user = new User()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                FirstName = "Pesho",
                LastName="Ivanov"
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            passwordHasher.HashPassword(user, "Admin*123");

            builder.Entity<User>().HasData(user);

            user = new User()
            {
                Id = "5176633b-6d3f-405f-8f75-adc61261d6d3",
                UserName = "Pavel",
                Email = "pavel@gmail.com",
                LockoutEnabled = false,
                FirstName = "Pavel",
                LastName = "Ivanchev"
            };

            passwordHasher = new PasswordHasher<User>();
            passwordHasher.HashPassword(user, "6pinier724++");
            builder.Entity<User>().HasData(user);

            user = new User()
            {
                Id = "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                UserName = "Daniel",
                Email = "daniel@gmail.com",
                LockoutEnabled = false,
                FirstName = "Daniel",
                LastName = "Ivanchev"
            };

            passwordHasher = new PasswordHasher<User>();
            passwordHasher.HashPassword(user, "6pinier724++");
            builder.Entity<User>().HasData(user);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "WAITER", ConcurrencyStamp = "2", NormalizedName = "Waiter" },
                new IdentityRole() { Id = "8572e5a7-c0cb-4b91-a456-ecf092ac4e81", Name = "USER", ConcurrencyStamp = "2", NormalizedName = "User" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "5176633b-6d3f-405f-8f75-adc61261d6d3" },
                new IdentityUserRole<string>() { RoleId = "8572e5a7-c0cb-4b91-a456-ecf092ac4e81", UserId = "4b7f2886-0c38-41b3-8281-b6fc1f465838" }
                );
        }
      
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSecondaryType> ProductSecondaryTypes { get; set; }
        public DbSet<Entity.ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
    }
}