using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Zelda.Models;

namespace Zelda.Repositories
{
    public class IceCreamRepository : RepositoryBase<IceCream, int,ZeldaContext>
    {
        public IceCreamRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }

        public override IceCream Create(IceCream entity)
        {
            var trackData =DbContext.IceCreams.Add(entity);
            
            return trackData.Entity;
        }

        public override IceCream Delete(IceCream entity)
        {
            throw new NotImplementedException();
        }

        public override IceCream Find(int id)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<IceCream> FindAll()
        {
            throw new NotImplementedException();
        }

        public override IQueryable<IceCream> FindByCondition(Expression<Func<IceCream, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public override IceCream Update(IceCream entity)
        {
            throw new NotImplementedException();
        }
    }
}
