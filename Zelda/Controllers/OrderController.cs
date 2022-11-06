using Microsoft.AspNetCore.Mvc;

namespace Zelda.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Type = "IceCream";
            return View();
        }
    }
}
