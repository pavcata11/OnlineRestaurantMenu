using OnlineRestaurantMenu.Models.Menu;
using OnlineRestaurantMenu.Models.Product;

namespace OnlineRestaurantMenu.Contracts
{
    public interface IMenuServise
    {
        public Task<IEnumerable<MenuFoodModel>> GetAllFoodTypesAsync();
        public Task<IEnumerable<MenuFoodModel>> GetAllDrinkTypesAsync();
        public Task<IEnumerable<ProductModel>> GetAllFoodByType(int id);

    }
}
