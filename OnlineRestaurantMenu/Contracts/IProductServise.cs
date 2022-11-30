using OnlineRestaurantMenu.Models;

namespace OnlineRestaurantMenu.Contracts
{
    public interface IProductServise
    {
        public Task<IEnumerable<DrinkTypesModel>> GetDrinkTypesAsync();
        public Task AddDrinkAsync(AddDrinkModel model);

    }
}
