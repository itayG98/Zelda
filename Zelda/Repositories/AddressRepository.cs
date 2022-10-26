using Zelda.Models;

namespace Zelda.Repositories
{
    public class AddressRepository : RepositoryBase<Address, int, ZeldaContext>
    {
        public AddressRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
