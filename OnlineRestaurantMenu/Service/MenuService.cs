using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data;
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

        public async Task<IEnumerable<MenuFoodModel>> GetAllFoodTypesAsync()
        {
            return await context.FoodTypes
                .Select(m => new MenuFoodModel()
                {
                    Type = m.Type,
                    Image = m.Image

                }).ToListAsync();
        }
    }
}
