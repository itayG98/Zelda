using Microsoft.AspNetCore.Mvc;
using System.Text;
using Zelda.Models;
using Zelda.Repositories;

namespace Zelda.Controllers
{
    public class IceCreamController : Controller
    {
        private readonly IceCreamRepository iceCreamRepository; 
        private readonly SyropRepository syropRepository;
        private readonly ToppingRepository toppingRepository;
        public IceCreamController(IceCreamRepository iceCrem_repo, SyropRepository syrop_repo,ToppingRepository topping_repo)
        {
            iceCreamRepository = iceCrem_repo;
            syropRepository = syrop_repo;
            toppingRepository = topping_repo;

        }

        public string GetMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ice-Creams:");
            iceCreamRepository.FindAll().Result.ToList().ForEach(x => sb.AppendLine(x.ToString()));
            sb.AppendLine("Syrops:");
            syropRepository.FindAll().Result.ToList().ForEach(x => sb.AppendLine(x.ToString()));
            sb.AppendLine("Topping:");
            toppingRepository.FindAll().Result.ToList().ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString();
        }


        public IActionResult Index()
        {
            return View(this);  
        }
    }
}
