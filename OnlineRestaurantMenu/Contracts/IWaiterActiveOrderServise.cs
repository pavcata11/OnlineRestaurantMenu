using OnlineRestaurantMenu.Models.Product;
using OnlineRestaurantMenu.Models.Waiter;

namespace OnlineRestaurantMenu.Contracts
{
    public interface IWaiterActiveOrderServise
    {
        public Task<IEnumerable<WaiterActiveOrderModel>> GetWaiterActiveOrderAsync(string userid);
    }
}
