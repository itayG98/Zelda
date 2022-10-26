using Zelda.Models;

namespace Zelda.Repositories
{
    public class OrdersRepository : ZeldaRepositoryBase<Order, Guid>
    {
        public OrdersRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }
    }
}
