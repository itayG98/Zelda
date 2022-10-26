using Zelda.Models;

namespace Zelda.Repositories
{
    public class SyropRepository : RepositoryBase<Syrop, int, ZeldaContext>
    {
        public SyropRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
