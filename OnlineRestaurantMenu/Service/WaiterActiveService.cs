using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Infrastructure.Data.Enums;
using OnlineRestaurantMenu.Models.Menu;
using OnlineRestaurantMenu.Models.Product;
using OnlineRestaurantMenu.Models.Waiter;

namespace OnlineRestaurantMenu.Service
{
    public class WaiterActiveService : IWaiterActiveOrderServise
    {
        private readonly ApplicationDbContext context;
        public WaiterActiveService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<WaiterActiveOrderModel>> GetWaiterActiveOrderAsync(string userId)
        {
            var OrderUser = context.Orders.Where(x => x.IsPay == false).ToList();
            List<WaiterActiveOrderModel> orders = new List<WaiterActiveOrderModel>();
            foreach (var ord in OrderUser)
            {
                var product = await (from pr in context.Sales
                                     join order in context.Order on pr.OrderId equals order.Id
                                     join produc in context.Products on pr.ProductId equals produc.Id
                                     where pr.OrderId == ord.Id
                                     select new ProductModel
                                     {
                                         Id = order.Id,
                                         Name = produc.Name,

                                     })
                                .ToListAsync();
                var waiterActiveOrderModel = new WaiterActiveOrderModel()
                {
                    Id = ord.Id,
                    ComoOnWaiter = ord.CallToWaiter,
                    OrderStatus = ord.IsPay,
                    Products = product
                };
                orders.Add(waiterActiveOrderModel);
            }
            return orders;
        }

    }
}
            
            
          /*  var result1 = await (from pr in context.Sales
                               join order in context.Order on pr.OrderId equals order.Id
                               join product in context.Products on pr.ProductId equals product.Id
                               where order.UserId == userId
                               select new WaiterActiveOrderModel
                               {
                                   Id = order.Id,
                                   ComoOnWaiter =  order.CallToWaiter,
                                   OrderStatus = order.IsPay,

                               })
                                .ToListAsync();
          

            foreach (var item in result1)
            {
                var result = context.Sales.Where(x => x.OrderId ==item.Id).ToList();
                List<ProductModel> products = new List<ProductModel>();
                foreach (var product in result)
                {
                    var currentProduct = await context.Products.Where(x => x.Id == product.ProductId).
                        Select(x => new ProductModel()
                        {
                            Name = x.Name,
                            Description = x.Description,
                        }).FirstOrDefaultAsync();
                    products.Add(currentProduct);
                }
                item.Products = products;
                break;
                
            }*/
         
     