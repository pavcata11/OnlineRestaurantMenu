using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;

namespace OnlineRestaurantMenu.Service
{
    public class ProductService : IProductServise
    {
        private readonly ApplicationDbContext context;
        public ProductService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task AddDrinkAsync(AddDrinkModel model)
        {
            var entity = new Drink()
            {
                Name = model.Name,
                Price = model.Price,
                Calories = model.Calories,
                Description = model.Description,
                Image = model.Image,
                DrinkTyepeId = model.TypeId,
                DrinkMainType = model.DrinkMainType,
            };
            await context.Drinks.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DrinkTypesModel>> GetDrinkTypesAsync()
        {
            return await context.DrinkTypes.Select(x => new DrinkTypesModel
            {
                Id = x.Id,
                Name = x.Type
            }).ToListAsync();

        }
    }
}
