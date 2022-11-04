using Microsoft.AspNetCore.Mvc;
using Zelda.Models;
using Zelda.Repositories;

namespace Zelda.Views.ViewComponents
{
    public class IceCreamViewComponent : IMenuItemViewComponentBase<IceCream, int>
    {
        public IceCreamViewComponent(IceCreamRepository imenuItemRepository) : base(imenuItemRepository)
        {
        }
    }
}
