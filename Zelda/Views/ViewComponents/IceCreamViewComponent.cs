using Microsoft.AspNetCore.Mvc;
using Zelda.Models;
using Zelda.Repositories;

namespace Zelda.Views.ViewComponents
{
    public class IceCreamViewComponent : ViewComponent
    {
        private readonly IceCreamRepository _iceCreamRepository;
        public IceCreamViewComponent(IceCreamRepository iceCreamRepository)
        {
            _iceCreamRepository = iceCreamRepository;
        }

        private IEnumerable<IceCream> FindAllIceCreams() =>  _iceCreamRepository.FindAll();

        public IViewComponentResult Invoke()
        {
            return View(FindAllIceCreams());
        }
    }
}
