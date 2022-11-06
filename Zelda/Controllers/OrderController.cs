using Microsoft.AspNetCore.Mvc;

namespace Zelda.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
