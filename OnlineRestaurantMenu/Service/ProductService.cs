using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;
using OnlineRestaurantMenu.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OnlineRestaurantMenu.Models.User;

namespace OnlineRestaurantMenu.Service
{
    public class ProductService:IProductServise
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private ApplicationDbContext context;
        public ProductService(ApplicationDbContext _context,
            UserManager<User> _userManager,
           SignInManager<User> _signInManager,
           RoleManager<IdentityRole> _roleManager)
        {
            context = _context;
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }

        public async Task AddProductAsync(AddProductModel model)
        {
            var entity = new Product()
            {
                Name = model.Name,
                Price = model.Price,
                Calories = model.Calories,
                Description = model.Description,
                Image = model.Image,
                Size = model.Size,
                TimeToget = model.TimeToGet,
                ProductSecondaryTypeId = model.ProductTypeId,
            };
            await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<Product?> EditProductAsync(int id)
        {
            return await context.Products.Where(x => x.Id == id)
                .Include(x => x.ProductSecondaryTypeId)
                .Select(x => new Product()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    Size = x.Size,
                    Calories = x.Calories,
                    Image = x.Image,
                    ProductSecondaryTypeId = x.ProductSecondaryTypeId
                }).FirstOrDefaultAsync();

        }



        public async Task<IEnumerable<ProductModel>> GetAllDrinksAsync()
        {
            return await context.Products.Include(x => x.ProductType)
                .Where(x => x.ProductSecondaryTypeId == 1)
                .Select(m => new ProductModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Description = m.Description,
                    Price = m.Price,
                    Calories = m.Calories,
                    Size = m.Size,
                    Image = m.Image,
                    ProductTypeId = m.ProductSecondaryTypeId,
                }).ToListAsync();
        }

        public async Task<IEnumerable<ProductTypesModel>> GetDrinkTypesAsync()
        {
            return await context.ProductSecondaryTypes
                .Where(x => x.Id == 1)
                .Select(x => new ProductTypesModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();
        }

        public async Task RemoveProductAsync(int id)
        {
            var entity = context.Products.Where(x => x.Id == id).FirstOrDefault();
            if (entity != null)
            {
                context.Products.Remove(entity);
                await context.SaveChangesAsync();
            }
        }
        public async Task<ProductModel?> EditDrink(int? id)
        {
            var types = await GetDrinkTypesAsync();

            var result  = await context.Products.Where(x => x.Id == id)
                .Where(x => x.Id == id)
                .Select(x => new ProductModel()
                {
                    Price = x.Price,
                    Size = x.Size,
                    Name = x.Name,
                    Description = x.Description,
                    ProductTypeId = x.ProductSecondaryTypeId,
                    Image = x.Image,
                    Calories = x.Calories,
                    ProductTypes = (List<ProductTypesModel>)types
                }
            ).FirstOrDefaultAsync();
            ;
            return result;
        }
        public async Task<IEnumerable<ProductTypesModel>> GetFoodTypesAsync()
        {
            return await context.ProductSecondaryTypes
                .Where(x=>x.Id==2)
                .Select(x => new ProductTypesModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();
        }

        public async Task AddFoodAsync(AddProductModel model)
        {

            var entity = new Product()
            {
                Name = model.Name,
                Size = model.Size,
                Price = model.Price,
                Calories = model.Calories,
                Description = model.Description,
                Image = model.Image,
                ProductSecondaryTypeId = model.ProductTypeId,
                TimeToget = model.TimeToGet,
            };
            await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<ProductModel?> EditFood(int? id)
        {
            var types = await context.ProductSecondaryTypes
                .Where(x => x.Id == 2)
                .Select(x => new ProductTypesModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();

            return await context.Products
                .Where(x => x.Id == id)
                .Select(x => new ProductModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    ProductTypeId = x.ProductSecondaryTypeId,
                    Size = x.Size,
                    Calories = x.Calories,
                    TimeToGet = x.TimeToget,
                    Image = x.Image,
                    ProductTypes = types,
                }).FirstOrDefaultAsync();
        }

        public async Task<Product> EditProduct(ProductModel model)
        {
            var entity = await context.Products.Where(x => x.Id == model.Id).FirstOrDefaultAsync();
            entity.Price = model.Price;
            entity.Description = model.Description;
            entity.Calories = model.Calories;
            entity.Image = model.Image;
            entity.ProductSecondaryTypeId = model.ProductTypeId;
            entity.Name = model.Name;
            entity.TimeToget = model.TimeToGet;
            context.Products.Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<ProductModel>> GetAllFoodsAsync()
        {
            return await context.Products
                 .Where(x => x.ProductSecondaryTypeId == 2)
                .Select(m => new ProductModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Description = m.Description,
                    Price = m.Price,
                    Calories = m.Calories,
                    TimeToGet = m.TimeToget,
                    Size = m.Size,
                    Image = m.Image,
                    ProductTypeId = m.ProductSecondaryTypeId,
                }).ToListAsync();
        }

    }
}
