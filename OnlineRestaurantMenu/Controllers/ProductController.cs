using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.DropBox;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;
using OnlineRestaurantMenu.Models.Product;
using OnlineRestaurantMenu.Models.Role;
using OnlineRestaurantMenu.Service;
using System.Security.Claims;

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

      
         [HttpPost]
        public async Task<IActionResult> AddInOrder(OrderModel model)
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            await productService.AddProdyctInOrderAsync(model, userId);

          
            var model1 = await productService.GetMyItems(userId);
            return View(model1);
        }
        [HttpGet]
        public async Task<IActionResult> AddInOrder()
        {
           
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var model = await productService.GetMyItems(userId);
            var tables = await productService.GetTablesAsync();
            ViewData["Tables"] = tables;
          
            return View(model);

            
        }
       
        public async Task<IActionResult> RemoveProductFromOrder(int id)
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            await productService.RemoveProductAsync(id);

            var model1 = await productService.GetMyItems(userId);
            return View(nameof(AddInOrder));
        }
       /* public async Task<IActionResult> SearchProduct(string? searchTerm = null, int pages = 1,int productPerPage=3)
        {
            var products= new List<Product>();
            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";
                products = products
                    .Where(c => EF.Functions.Like(c.Make, searchTerm)
                    EF.Functions.Like(c.CarModel, searchTerm)
                    EF.Functions.Like(c.Description.ToLower(), searchTerm));
            }
            return View(nameof(AddInOrder));
        }*/
        







    }
}


    
    
    
    

