using Zelda.Models;

namespace Zelda.Repositories
{
    public class OrdersRepository : RepositoryBase<Order, Guid, ZeldaContext>
    {
        public OrdersRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
