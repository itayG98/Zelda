using Microsoft.AspNetCore.Mvc;
using System.Text;
using Zelda.Models;
using Zelda.Repositories;

namespace Zelda.Controllers
{
    public class HomeController : Controller
    {
        private readonly IceCreamRepository iceCreamRepository; 
        private readonly SyropRepository syropRepository;
        private readonly ToppingRepository toppingRepository;
        public HomeController(IceCreamRepository iceCrem_repo, SyropRepository syrop_repo,ToppingRepository topping_repo)
        {
            iceCreamRepository = iceCrem_repo;
            syropRepository = syrop_repo;
            toppingRepository = topping_repo;
        }


        public IActionResult Index()
        {
            return View(this);  
        }
    }
}
