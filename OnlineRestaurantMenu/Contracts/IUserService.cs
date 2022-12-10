
using Microsoft.AspNetCore.Identity;
using OnlineRestaurantMenu.Models.User;

namespace OnlineRestaurantMenu.Contracts
{
    public interface IUserServise
    {
        public Task<IEnumerable<UserModel>> GetAllUserAsync();

        public Task<List<IdentityRole>> GetUserRoles();

        public Task<Infrastructure.Data.Entity.User> EditUserAsync(UserModel model);

        public Task<UserModel?> EditUserAsync(string id);
    }
}
