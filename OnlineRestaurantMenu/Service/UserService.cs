using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;
using OnlineRestaurantMenu.Models.Role;
using OnlineRestaurantMenu.Models.User;
using System.Data;
using static OnlineRestaurantMenu.Infrastructure.Data.Constants.DataConstants;

namespace OnlineRestaurantMenu.Service
{
    public class UserService : IUserServise
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Infrastructure.Data.Entity.User> userManager;
        private readonly SignInManager<Infrastructure.Data.Entity.User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserService(
               ApplicationDbContext _context,
               UserManager<Infrastructure.Data.Entity.User> _userManager,
               SignInManager<Infrastructure.Data.Entity.User> _signInManager,
               RoleManager<IdentityRole> _roleManager
            )
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
            context = _context;
        }
        private async void createRolesandUsers()
        {
          


            // In Startup iam creating first Admin Role and creating a default Admin User     
            if (!await roleManager.RoleExistsAsync("Admin"))
            {

                // first we create Admin rool    
                var role  = new IdentityRole();
                role.Name = "Admin";
                await roleManager.CreateAsync(role);

                //Here we create a Admin super user who will maintain the website                   
            }

        
        }
        public async Task<List<IdentityRole>> GetUserRoles()
        {
            var roles =  await roleManager.Roles.ToListAsync();

            string r = roles[0].Name;
            return roles;

           
        }
        private async Task<IEnumerable<string>> GetRolesString()
        {
            var roles = await roleManager.Roles.ToListAsync();
            List<string> roles1 = new List<string>();  
            foreach (var item in roles)
            {
                roles1.Add(item.Name);  
            }
            return roles1.AsEnumerable();
        }

        public async Task<Infrastructure.Data.Entity.User> EditUserAsync(UserModel model)
        {
            var u = await userManager.FindByIdAsync(model.Id);
            if (u != null)
            {
                await userManager.RemoveFromRoleAsync(u, "Admin");
                await userManager.RemoveFromRoleAsync(u, "Server");
            }
            context.SaveChanges();
            var entity = await context.Users.Where(x => x.Id == model.Id).FirstOrDefaultAsync();
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.Email = model.Email;
            entity.Age = model.Age;

           

          

          
            context.Users.Update(entity);
            await context.SaveChangesAsync();

            var role = await roleManager.FindByIdAsync(model.Role.Id);
            await userManager.AddToRoleAsync(entity, role.Name);

           

            context.Users.Update(entity);
            await context.SaveChangesAsync();
          
            return entity;

        }

        public async Task<UserModel?> EditUserAsync(string id)
        {
            
            var x = await context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            IdentityRole role = new IdentityRole() ;
            foreach (var item in await userManager.GetRolesAsync(x))
            {
               role = await roleManager.FindByNameAsync(item);
                
            }
            return new UserModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Username = x.UserName,
                Age = x.Age,
                Role = role,
                Roles = await GetUserRoles(),

              };
        }
        public string Role { get; set; }

        public UserManager<Infrastructure.Data.Entity.User> GetUserManager()
        {
            return userManager;
        }

        public async Task<IEnumerable<UserModel>> GetAllUserAsync()
        {
            /*userManager.AddToRoleAsync(user.Id, "<Role>");*/
           List<UserModel>users = new List<UserModel>();
         
            foreach (var user in await context.Users.ToListAsync())
            {
                var result = new UserModel();
                result.Email = user.Email;
                result.FirstName = user.FirstName;  
                result.LastName = user.LastName;
                result.Age = user.Age;
                result.Username = user.UserName;
                result.Id = user.Id;
                
                foreach (var item in await userManager.GetRolesAsync(user))
                {
                    var role = await roleManager.FindByNameAsync(item);
                    result.Role = role;
                }
                users.Add(result);



            }
           
            
            
         return users;  

         /*   var result1 =await  roleManager.Roles.AnyAsync();*/
        }

       
    }
}
