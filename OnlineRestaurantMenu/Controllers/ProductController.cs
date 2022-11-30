using Microsoft.AspNetCore.Mvc;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Models;
using OnlineRestaurantMenu.Service;

namespace OnlineRestaurantMenu.Controllers
{
    public class ProductController:Controller
    {
        private readonly IProductServise productService;
        public ProductController(IProductServise _productServise)
        {
            productService = _productServise;
        }
        [HttpGet]
        public async Task<IActionResult> AddDrink()
        {
            var model = new AddDrinkModel()
            {
                DrinkTypes = await productService.GetDrinkTypesAsync()
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddDrink(AddDrinkModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await productService.AddDrinkAsync(model);
                return RedirectToAction(nameof(AddDrink));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }
        }
    }
}
