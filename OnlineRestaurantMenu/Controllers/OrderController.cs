using Microsoft.AspNetCore.Mvc;

namespace OnlineRestaurantMenu.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
