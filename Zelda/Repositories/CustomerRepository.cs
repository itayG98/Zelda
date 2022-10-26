using Zelda.Models;

namespace Zelda.Repositories
{
    public class CustomerRepository : ZeldaRepositoryBase<Costumer, string>
    {
        public CustomerRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
