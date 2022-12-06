using Microsoft.EntityFrameworkCore;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Infrastructure.Data;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;
using OnlineRestaurantMenu.Models;

namespace OnlineRestaurantMenu.Service
{
    public class ProductService : IProductServise
    {
        private readonly ApplicationDbContext context;
        public ProductService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task AddDrinkAsync(AddDrinkModel model)
        {
            var entity = new Drink()
            {
                Name = model.Name,
                Price = model.Price,
                Calories = model.Calories,
                Description = model.Description,
                Image = model.Image,
                DrinkTyepeId = model.TypeId,
                DrinkMainType = model.DrinkMainType,
            };
            await context.Drinks.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<DrinkModel?> EditDrinkAsync(int id)
        {

            return await context.Drinks.Where(x => x.Id == id).Include(x=>x.Type).Select(x => new DrinkModel()
            {
                Id = x.Id,
                Name = x.Name,  
                Description = x.Description,
                Price   =x.Price,
                TypeId = x.DrinkTyepeId,
                Size = x.Size,
                Calories = x.Calories,
                Image = x.Image
            }).FirstOrDefaultAsync();
        }

        public async Task<Drink> EditDrinkAsync(DrinkModel model)
        {
            var entity = await context.Drinks.Where(x => x.Id == model.Id).FirstOrDefaultAsync();
            entity.Price = model.Price;
            entity.Description = model.Description;
            entity.Calories = model.Calories;   
            entity.Image = model.Image;
            entity.DrinkTyepeId = model.TypeId;
            entity.Name = model.Name;
            context.Drinks.Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<DrinkModel>> GetAllDrinksAsync()
        {
            return await context.Drinks
                .Include(x => x.Type)
                .Select(m => new DrinkModel()
                {
                    Id=m.Id,    
                    Name = m.Name,
                    Description = m.Description,
                    Price = m.Price,
                    Calories = m.Calories,
                    Size = m.Size,
                    Image = m.Image,
                    TypeId = m.DrinkTyepeId,
                }).ToListAsync();
        }

        public async Task<IEnumerable<DrinkTypesModel>> GetDrinkTypesAsync()
        {
            return await context.DrinkTypes.Select(x => new DrinkTypesModel
            {
                Id = x.Id,
                Name = x.Type
            }).ToListAsync();

        }

        public async Task RemoveDrinkAsync(int id)
        {
            var entity = context.Drinks.Where(x=>x.Id== id).FirstOrDefault();
            if (entity != null)
            {
                context.Drinks.Remove(entity);
                await context.SaveChangesAsync();
            }
           
        }

       
        public async Task<DrinkModel?> EditDrink(int? id)
        {
            var types = await context.DrinkTypes.Select(x => new DrinkTypesModel
            {
                Id = x.Id,
                Name = x.Type
            }).ToListAsync();

            return await context.Drinks.Where(x => x.Id == id).Select(x => new DrinkModel()
            {
                Price = x.Price,
                Size = x.Size,
                Name = x.Name,
                Description = x.Description,
                TypeId = x.DrinkTyepeId,
                Image = x.Image,
                Calories = x.Calories,
                DrinkTypes = types


            }
            ).FirstOrDefaultAsync();
        }

        public Task<DrinkModel> RemoveDrink(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
