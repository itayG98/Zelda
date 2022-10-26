using Zelda.Models;

namespace Zelda.Repositories
{
    public class CustomerRepository : RepositoryBase<Costumer, string, ZeldaContext>
    {
        public CustomerRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
