using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;

namespace OnlineRestaurantMenu.Contracts
{
    public interface IMenuServise
    {
        public Task<IEnumerable<MenuFoodModel>> GetAllFoodTypesAsync();
        public Task<IEnumerable<MenuFoodModel>> GetAllDrinkTypesAsync();

    }
}
