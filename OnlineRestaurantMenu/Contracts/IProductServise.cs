using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;

namespace OnlineRestaurantMenu.Contracts
{
    public interface IProductServise
    {
        public Task<IEnumerable<DrinkTypesModel>> GetDrinkTypesAsync();
        public Task AddDrinkAsync(AddDrinkModel model);
        public Task<DrinkModel> EditDrink(int? id);
        public Task<Drink> EditDrinkAsync(DrinkModel model);
        public Task<IEnumerable<DrinkModel>> GetAllDrinksAsync();
        public Task RemoveDrinkAsync(int id);

    }
}
