using Microsoft.AspNetCore.Mvc;
using OnlineRestaurantMenu.Models;
using System.Diagnostics;

namespace OnlineRestaurantMenu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("FoodsTypes", "Menu");
            }
            return View();
        }
    }
}