using Microsoft.AspNetCore.Mvc;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;
using OnlineRestaurantMenu.Models.Product;

namespace OnlineRestaurantMenu.Contracts
{
    public interface IProductServise
    {
        public Task AddProductAsync(AddProductModel model);
        public Task<Product?> EditProductAsync(int id);
        public  Task<IEnumerable<ProductModel>> GetAllDrinksAsync();
        public Task<IEnumerable<ProductTypesModel>> GetDrinkTypesAsync();
        public Task RemoveProductAsync(int id);
        public Task<ProductModel?> EditDrink(int? id);
        public  Task<IEnumerable<ProductTypesModel>> GetFoodTypesAsync();
        public Task AddFoodAsync(AddProductModel model);
        public Task<ProductModel?> EditFood(int? id);
        public Task<Product> EditProduct(ProductModel model);
        public Task<IEnumerable<ProductModel>> GetAllFoodsAsync();
        public Task AddProdyctInOrderAsync(OrderModel model,string userId);
        public Task<IEnumerable<OrderModel>> GetMyItems(string user);
        public Task RemoveProductFromOrder(int id, string userId);
        public Task<IEnumerable<TableModel>> GetTablesAsync();
    }
}
