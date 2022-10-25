using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Zelda.Models;

namespace Zelda.Repositories
{
    public class IceCreamRepository : RepositoryBase<IceCream, int, ZeldaContext>
    {
        public IceCreamRepository(ZeldaContext dbContext) : base(dbContext)
        {
        }

        public override async Task Create(IceCream entity)
        {
            await DbContext.IceCreams.AddAsync(entity);
            await SaveAsync();
        }

        public override async Task Delete(IceCream entity)
        {
            var del = new Task(() => DbContext.IceCreams.Remove(entity));
            del.Start();
            Task save = del.ContinueWith(_ => SaveAsync()) ;
        }

        public override Task<IceCream> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<IQueryable<IceCream>> FindAll()
        {
            throw new NotImplementedException();
        }

        public override Task<IQueryable<IceCream>> FindByCondition(Expression<Func<IceCream, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public override async Task Update(IceCream entity)
        {
            var del = new Task(() => DbContext.IceCreams.Update(entity));
            del.Start();
            Task save = del.ContinueWith(_ => SaveAsync());
        }
    }
}
