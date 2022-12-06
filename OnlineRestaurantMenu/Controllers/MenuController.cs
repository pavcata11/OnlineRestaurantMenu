using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineRestaurantMenu.Contracts;

namespace Watchlist.Controllers
{
    [Authorize]
    public class MenuController : Controller
    {
        private readonly IMenuServise menuServise;
        public MenuController(IMenuServise _menuServise)
        {
            menuServise=_menuServise;
        }
        [HttpGet]
        public async Task<IActionResult> FoodsTypes()
        {
            var model = await menuServise.GetAllFoodTypesAsync();
            return View(model);
        }
        public async Task<IActionResult> DrinksTypes()
        {
            var model = await menuServise.GetAllDrinkTypesAsync();
            return View(model);
        }
        public async Task<IActionResult> FoodsByType(int id)
        {
            var model = await menuServise.GetAllFoodByType(id);
            return View(model);
        }


    }
}
