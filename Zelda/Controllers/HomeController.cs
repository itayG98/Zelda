using Microsoft.AspNetCore.Mvc;
using Zelda.Models;
using Zelda.Repositories;

namespace Zelda.Controllers
{
    public class HomeController : Controller
    {
        private IceCreamRepository repository;
        public HomeController(IceCreamRepository repo)
        {
            repository = repo;
            //Init();
        }

        private async Task Init() => await repository.Create(new IceCream() { Name = "Chocolate", Price = 10 });


        public IActionResult Index()
        {
            return View();
        }
    }
}
