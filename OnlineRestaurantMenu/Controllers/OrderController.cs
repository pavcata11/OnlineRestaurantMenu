using Microsoft.AspNetCore.Mvc;
using OnlineRestaurantMenu.Contracts;
using OnlineRestaurantMenu.Models.Product;
using OnlineRestaurantMenu.Service;
using System.Security.Claims;

namespace OnlineRestaurantMenu.Controllers
{
    public class OrderController : Controller
    {
        private readonly IWaiterActiveOrderServise waiterActiveOrderServise;
        public OrderController(IWaiterActiveOrderServise _waiterActiveOrderServise)
        {
            waiterActiveOrderServise = _waiterActiveOrderServise;
        }

        [HttpGet]
        public async Task<IActionResult> WaiterActiveOrder()
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var model = await waiterActiveOrderServise.GetWaiterActiveOrderAsync(userId);
            return View(model);
        }

    }
}
