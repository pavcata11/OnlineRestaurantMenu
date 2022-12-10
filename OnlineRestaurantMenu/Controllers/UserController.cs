using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;
using OnlineRestaurantMenu.Models.User;
using OnlineRestaurantMenu.Service;

namespace OnlineRestaurantMenu.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserServise userService;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(
            IUserServise _userService,
           UserManager<User> _userManager,
           SignInManager<User> _signInManager,
           RoleManager<IdentityRole> _roleManager
            )
        {
            userService = _userService;
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("FoodsTypes", "Menu");
            }
            var model = new RegisterViewModel();
            return View(model);
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName
            };
            var result = await userManager.CreateAsync(user,model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "User");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("FoodsTypes", "Menu");
            }
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("FoodsTypes", "Menu");
                }
            }
            ModelState.AddModelError("","Invalig login");
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> AllUser(int pg = 1)
        {
            var model = await userService.GetAllUserAsync();

            const int pageSize = 5;
            if (pg < 1)
            {
                pg = 1;
            }
            int resCount = model.Count();
            var pager = new Pager(resCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = model.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;

            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(UserModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await userService.EditUserAsync(model);
                return RedirectToAction(nameof(AllUser));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }

        }
        [HttpGet]
        public async Task<IActionResult> EditUser(string Id)
        {
            var model = await userService.EditUserAsync(Id);
            return View(model);
        }
    }
}
