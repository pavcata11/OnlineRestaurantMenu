using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;

namespace OnlineRestaurantMenu.Service
{
    public class MenuService : IMenuServise
    {
        private readonly ApplicationDbContext context;
        public MenuService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<MenuFoodModel>> GetAllDrinkTypesAsync()
        {
            return await context.DrinkTypes
             .Select(m => new MenuFoodModel()
             {
                 Type = m.Type,
                 Image = m.Image

             }).ToListAsync();
        }

        public async Task<IEnumerable<Food>> GetAllFoodByType(int id)
        {
            return await context.Foods.Where(x => x.TypeId == id).Select(x => new Food
            {
                Name = x.Name,
                Price = x.Price,
                Calories = x.Calories,
                Description = x.Description,
                TimeToGet = x.CookingTime,

            }).ToListAsync();
        }

        public async Task<IEnumerable<MenuFoodModel>> GetAllFoodTypesAsync()
        {
            return await context.FoodTypes
                .Select(m => new MenuFoodModel()
                {
                    Id = m.Id,
                    Type = m.Type,
                    Image = m.Image

                }).ToListAsync();
        }
    }
}
