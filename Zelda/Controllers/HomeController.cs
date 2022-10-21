using Microsoft.AspNetCore.Mvc;

namespace Zelda.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
