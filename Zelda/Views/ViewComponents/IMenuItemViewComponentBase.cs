using Microsoft.AspNetCore.Mvc;
using Zelda.Models;
using Zelda.Repositories;

namespace Zelda.Views.ViewComponents
{
    public abstract class IMenuItemViewComponentBase<T,K> :  ViewComponent where T:class 
    {
        private readonly ZeldaRepositoryBase<T,K> _imenuItemRepository;
        public IMenuItemViewComponentBase(ZeldaRepositoryBase<T,K> imenuItemRepository)
        {
            _imenuItemRepository = imenuItemRepository;
        }

        private IEnumerable<T> FindAll() => _imenuItemRepository.FindAll();

        public IViewComponentResult Invoke()
        {
            return View(FindAll());
        }
    }
}
