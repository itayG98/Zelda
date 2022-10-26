using Zelda.Models;

namespace Zelda.Repositories
{
    public class IceCreamRepository : ZeldaRepositoryBase<IceCream, int>
    {
        public IceCreamRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
