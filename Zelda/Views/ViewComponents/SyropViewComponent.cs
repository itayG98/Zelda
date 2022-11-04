using Zelda.Models;
using Zelda.Repositories;

namespace Zelda.Views.ViewComponents
{
    public class SyropViewComponent : IMenuItemViewComponentBase<Syrop, int>
    {
        public SyropViewComponent(SyropRepository imenuItemRepository) : base(imenuItemRepository)
        {
        }
    }
}
