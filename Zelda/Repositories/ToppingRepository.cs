using Zelda.Models;

namespace Zelda.Repositories
{
    public class ToppingRepository : ZeldaRepositoryBase<Topping, int>
    {
        public ToppingRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
