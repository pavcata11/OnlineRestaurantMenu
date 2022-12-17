using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models.Product;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace OnlineRestaurantMenu.Service
{
    public class ProductService : IProductServise
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
            var result = await (from pr in context.Products
                          join secondaryType in context.ProductSecondaryTypes on pr.ProductSecondaryTypeId equals secondaryType.Id
                          join MainType in context.ProductTypes on secondaryType.ProductTypeId equals MainType.Id
                          where MainType.Id==1
                          select new ProductModel
                          {
                              Id = pr.Id,
                              Name = pr.Name,
                              Description = pr.Description,
                              Price = pr.Price,
                              Calories = pr.Calories,
                              Size = pr.Size,
                              Image = pr.Image,
                              ProductTypeId = secondaryType.Id,
                          }).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<ProductTypesModel>> GetDrinkTypesAsync()
        {
            return await context.ProductSecondaryTypes
                .Where(x => x.ProductTypeId == 1)
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
                .Where(x=>x.ProductTypeId==2)
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
            var result = await (from pr in context.Products
                                join secondaryType in context.ProductSecondaryTypes on pr.ProductSecondaryTypeId equals secondaryType.Id
                                join MainType in context.ProductTypes on secondaryType.ProductTypeId equals MainType.Id
                                where MainType.Id == 2
                                select new ProductModel
                                {
                                    Id = pr.Id,
                                    Name = pr.Name,
                                    Description = pr.Description,
                                    Price = pr.Price,
                                    Calories = pr.Calories,
                                    Size = pr.Size,
                                    Image = pr.Image,
                                    ProductTypeId = secondaryType.Id,
                                }).ToListAsync();

            return result;

        }

        public async Task<IEnumerable<OrderModel>> GetMyItems(string user)
        {
            List<OrderModel> list = new List<OrderModel>();
            var result = await (from pr in context.Sales
                                join order in context.Order on pr.OrderId equals order.Id
                                join product in context.Products on pr.ProductId equals product.Id
                                where order.UserId == user
                                select new OrderModel
                                {
                                    Id = product.Id,
                                    Name = product.Name,
                                    Description = product.Description,
                                    Price = product.Price,
                                    Calories = product.Calories,
                                    Size = product.Size,
                                    Image = product.Image,
                                    Count = pr.CountOfSalesThisItem,
                                })
                                .ToListAsync();
            
         

         
        
            
           

            return result;

        }

        public async Task AddProdyctInOrderAsync(OrderModel model,string userId)
        {
            var id =await context.Products
                .Where(x=>x.Name==model.Name)
                .Select(x=>x.Id)
                .FirstOrDefaultAsync();
            int count = model.Count;
            var canUserhasAOrder = context.Orders.Where(x => x.UserId == userId && x.IsPay == false).FirstOrDefault();
            if (canUserhasAOrder == null)
            {
                var order = new Order()
                {
                    UserId = userId,
                    IsPay = false,
                    CallToWaiter = false,
                    TableId = null,
                };
                await context.AddAsync(order);
                await context.SaveChangesAsync();
            }

            var myOrder = context.Orders.Where(x => x.UserId == userId && x.IsPay == false).FirstOrDefault();
            if(myOrder != null) 
            {
                var sale = new Sales()
                {
                    CountOfSalesThisItem = model.Count,
                    ProductId = id,
                    OrderId = myOrder.Id,
                };
                context.Sales.Add(sale);
                await context.SaveChangesAsync();
              
                
            }
            var sales = context.Sales.ToList();
            foreach (var item in sales)
            {
                var tem = sales.Where(x => x.ProductId == item.ProductId && x.OrderId == item.OrderId && x.IsDeleted==false).FirstOrDefault();
                if (tem != null)
                {

                    if (item.Id != tem.Id)
                    {
                        tem.CountOfSalesThisItem += item.CountOfSalesThisItem;
                        context.Remove(item);
                        context.SaveChanges();
                    }

                }
            }



            /*var product =await context.Products.Where(x=>x.Id== productId).FirstOrDefaultAsync();
            var order = new Order()
            {
                UserId = userId,
                IsPay = false,
                CallToWaiter = false,
                TableId = null,
            };
            await context.AddAsync(order);
            await context.SaveChangesAsync();
            var orderId = context.Orders.Where(x=>x.UserId==userId).FirstOrDefault();
            var sale = new Sales()
            {
                ProductId = productId,
            };*/

        }

        public async Task RemoveProductFromOrder(int id,string userId)
        {
          

            context.SaveChanges();
            var currentOrder = context
                .Orders
                .Where(x => x.UserId == userId && x.IsPay == false)
                .Select(x=>x.Id)
                .FirstOrDefault();
            var sale = await context.Sales.FirstOrDefaultAsync(x => x.ProductId== id && x.OrderId== currentOrder);
            sale.IsDeleted = true;
            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<TableModel>> GetTablesAsync()
        {
            return await context.Tables
                .Select(x => new TableModel
                {
                    Id = x.Id,
                    Description = x.Description,
                    CountOfSeats = x.CountOfSeats,
                    Number = x.Number,
                    
                }).ToListAsync();
        }





    }
}
