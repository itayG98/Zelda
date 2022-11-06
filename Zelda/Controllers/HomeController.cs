using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Text;
using Zelda.Models;
using Zelda.Repositories;
using Zelda.Views.ViewComponents;

namespace Zelda.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }


        public IActionResult Index()
        {
            return View(this);  
        }  
        public IActionResult StartOrder()
        {
            return RedirectToAction("Index", "Order", default);
        }


    }
}
