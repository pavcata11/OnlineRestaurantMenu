﻿using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models.Menu;
using OnlineRestaurantMenu.Models.Product;

namespace OnlineRestaurantMenu.Service
{
    public class MenuService :IMenuServise
    {
        private readonly ApplicationDbContext context;
        public MenuService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<MenuFoodModel>> GetAllDrinkTypesAsync()
        {
            return await context.ProductSecondaryTypes
                .Where(x=>x.Id==1)
             .Select(m => new MenuFoodModel()
             {
                 Type =  m.Name,
                 Image = m.Image

             }).ToListAsync();
        }

        public async Task<IEnumerable<ProductModel>> GetAllFoodByType(int id)
        {
            return await context.Products.Where(x => x.ProductSecondaryTypeId == id).Select(x => new ProductModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Calories = x.Calories,
                Description = x.Description,
                TimeToGet = x.TimeToget,
                Image = x.Image,
                Size = x.Size

            }).ToListAsync();
        }

        public async Task<IEnumerable<MenuFoodModel>> GetAllFoodTypesAsync()
        {
            return await context.ProductSecondaryTypes
                 .Where(x => x.Id == 2)
                .Select(m => new MenuFoodModel()
                {
                    Type = m.Name,
                    Image = m.Image

                }).ToListAsync();
        }

    }
}
