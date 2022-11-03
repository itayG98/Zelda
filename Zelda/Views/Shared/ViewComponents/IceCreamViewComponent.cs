using Microsoft.AspNetCore.Mvc;
using Zelda.Repositories;

namespace Zelda.Views.Shared.ViewComponents
{
    public class IceCreamViewComponent : ViewComponent
    {
        private readonly IceCreamRepository _iceCreamRepository;
        public IceCreamViewComponent(IceCreamRepository iceCreamRepository)
        {
            _iceCreamRepository = iceCreamRepository;
        }
    }
}
