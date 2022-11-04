using Zelda.Models;
using Zelda.Repositories;

namespace Zelda.Views.ViewComponents
{
    public class ToppingViewComponent : IMenuItemViewComponentBase<Topping, int>
    {
        public ToppingViewComponent(ToppingRepository imenuItemRepository) : base(imenuItemRepository)
        {
        }
    }
}
