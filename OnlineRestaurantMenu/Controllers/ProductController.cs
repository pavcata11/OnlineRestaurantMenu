using Microsoft.AspNetCore.Mvc;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.DropBox;
using OnlineRestaurantMenu.Models;
using OnlineRestaurantMenu.Models.Product;
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
            /*  var model = new AddDrinkModel()
              {
                  DrinkTypes = await productService.GetDrinkTypesAsync()
              };*/
            SingleFileModel model = new SingleFileModel();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> AddFood()
        {
            var model = new AddProductModel()
            {
                FoodType = await productService.GetFoodTypesAsync()
            };

            return View(model);
        }
     
        
        [HttpPost]
        public async Task<IActionResult> AddDrink(SingleFileModel model )
        {
            
           
         

           /* if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {*/
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                //get file extension
                FileInfo fileInfo = new FileInfo(model.File.FileName);
                string fileName = model.FileName + fileInfo.Extension;

                string fileNameWithPath = Path.Combine(path, fileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    model.File.CopyTo(stream);
                }
                model.IsSuccess = true;
                model.Message = "File upload successfully";
                await DropBoxUploadFile.Upload(fileNameWithPath, fileName);
           
            await productService.AddDrinkAsync(model);
                return RedirectToAction(nameof(AddDrink));

            /*}
                catch (Exception)
                {
                    ModelState.AddModelError("", "Something went wrong");
                    return View(model);
                }*/
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
                return RedirectToAction(nameof(AddFood));
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
        public async Task<IActionResult> EditFood(int Id)
        {
            var model = await productService.EditFood(Id);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveDrink(int Id)
        {
            await productService.RemoveDrinkAsync(Id);
            return RedirectToAction(nameof(AllDrinks));
        }
        [HttpGet]
        public async Task<IActionResult> RemoveFood(int Id)
        {
            await productService.RemoveFoodAsync(Id);
            return RedirectToAction(nameof(AllFoods));
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

        [HttpPost]
        public async Task<IActionResult> EditFood(FoodModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await productService.EditFoodAsync(model);
                return RedirectToAction(nameof(AllFoods));
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


    }
}
