using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Infrastructure.Data.Configuration;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
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
            builder.ApplyConfiguration(new CafeConfiguration());
            builder.ApplyConfiguration(new DrinkTypeConfiguration());
            builder.ApplyConfiguration(new DrinkConfiguration());
            builder.ApplyConfiguration(new FoodTypeConfiguration());
            builder.ApplyConfiguration(new FoodConfiguration());
            builder.ApplyConfiguration(new SuppElementConfiguration());
            base.OnModelCreating(builder);
        }
        public DbSet<Cafe> Cafe { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<DrinkType> DrinkTypes { get; set; }
        public DbSet<Foods> Foods { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplements> Supplements { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
    }
}