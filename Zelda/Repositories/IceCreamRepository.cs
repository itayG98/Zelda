using Zelda.Models;

namespace Zelda.Repositories
{
    public class IceCreamRepository : RepositoryBase<IceCream, int, ZeldaContext>
    {
        public IceCreamRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
