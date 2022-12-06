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
        [HttpGet]
        public async Task<IActionResult> EditDrink(int Id)
        {
           var model = await productService.EditDrink(Id);
           return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveDrink(int Id)
        {
            await productService.RemoveDrinkAsync(Id);
            return RedirectToAction(nameof(AllDrinks));
        }


        [HttpPost]
        public async Task<IActionResult> EditDrink(DrinkModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await productService.EditDrinkAsync(model);
                return RedirectToAction(nameof(AllDrinks));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }
          
        }



        [HttpGet]
        public async Task<IActionResult> AllDrinks(int pg=1)
        {
            var model = await productService.GetAllDrinksAsync();

            const int pageSize = 5;
            if (pg < 1)
            {
                pg = 1;
            }
            int resCount = model.Count();
            var pager = new Pager(resCount,pg,pageSize);
            int recSkip = (pg-1) * pageSize;
            var data = model.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;

            return View(data);
        }


    }
}
