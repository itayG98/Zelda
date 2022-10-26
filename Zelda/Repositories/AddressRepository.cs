using Zelda.Models;

namespace Zelda.Repositories
{
    public class AddressRepository : ZeldaRepositoryBase<Address, int>
    {
        public AddressRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
