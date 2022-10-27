using Microsoft.AspNetCore.Mvc;
using System.Text;
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
        }


        public string Index()
        {
            StringBuilder sb = new StringBuilder();
            repository.FindAll().Result.ToList().ForEach(x => sb.AppendLine(x.ToString()));
            return $"The Ice-Creams are :\n{sb}";
        }
    }
}
