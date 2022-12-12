using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;
using OnlineRestaurantMenu.Models.Product;

namespace OnlineRestaurantMenu.Contracts
{
    public interface IProductServise
    {
        public Task<IEnumerable<DrinkTypesModel>> GetDrinkTypesAsync();
        public Task<IEnumerable<DrinkTypesModel>> GetFoodTypesAsync();
        public Task AddDrinkAsync(SingleFileModel model);
        public Task AddFoodAsync(AddProductModel model);
        public Task<DrinkModel> EditDrink(int? id);
        public Task<FoodModel> EditFood(int? id);
        public Task<Drink> EditDrinkAsync(DrinkModel model);
        public Task<Foods> EditFoodAsync(FoodModel model);

        public Task<IEnumerable<DrinkModel>> GetAllDrinksAsync();
        public Task<IEnumerable<FoodModel>> GetAllFoodsAsync();
        public Task RemoveDrinkAsync(int id);
        public Task RemoveFoodAsync(int id);

    }
}
