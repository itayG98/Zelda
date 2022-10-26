using Zelda.Models;

namespace Zelda.Repositories
{
    public class SyropRepository : ZeldaRepositoryBase<Syrop, int>
    {
        public SyropRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
