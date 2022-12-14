using Microsoft.AspNetCore.Mvc;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.DropBox;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;
using OnlineRestaurantMenu.Models.Product;
using OnlineRestaurantMenu.Models.Role;
using OnlineRestaurantMenu.Service;

namespace OnlineRestaurantMenu.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServise productService;
        public ProductController(IProductServise _productServise)
        {
            productService = _productServise;
        }

        [HttpGet]
        public async Task<IActionResult> AddDrink()
        {
            AddProductModel model = new AddProductModel()
            {
                ProductTypes = (List<ProductTypesModel>)await productService.GetDrinkTypesAsync(),
            };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> AddFood()
        {
            var model = new AddProductModel()
            {
                ProductTypes = (List<ProductTypesModel>)await productService.GetFoodTypesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddDrink(AddProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await productService.AddProductAsync(model);
                return RedirectToAction(nameof(AllDrinks));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddFood(AddProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await productService.AddFoodAsync(model);
                return RedirectToAction(nameof(AllFoods));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }
        }
        [HttpGet]
        public async Task<IActionResult> AllDrinks(int pg = 1)
        {
            var model = await productService.GetAllDrinksAsync();

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
        [HttpGet]
        public async Task<IActionResult> AllFoods(int pg = 1)
        {
            var model = await productService.GetAllFoodsAsync();

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
        [HttpGet]
        public async Task<IActionResult> EditDrink(int Id)
        {
            var model = await productService.EditDrink(Id);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> EditFood(int Id)
        {
            var model = await productService.EditFood(Id);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> RemoveProduct(int Id)
        {
            await productService.RemoveProductAsync(Id);
            if (Id == 1)
            {
                return RedirectToAction(nameof(AllDrinks));
            }
            else
            {
                return RedirectToAction(nameof(AllFoods));
            }
            
            
        }
        [HttpPost]
        public async Task<IActionResult> EditDrink(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await productService.EditProduct(model);
                return RedirectToAction(nameof(AllDrinks));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }

        }
        [HttpPost]
        public async Task<IActionResult> EditFood(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await productService.EditProduct(model);
                return RedirectToAction(nameof(AllFoods));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }

        }

        



    }
}


    
    
    
    

