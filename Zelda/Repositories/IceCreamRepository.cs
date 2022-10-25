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
            if (entity != default)
            {
                var del = new Task(() => DbContext.IceCreams.Remove(entity));
                del.Start();
                Task save = del.ContinueWith(_ => SaveAsync());
            }
        }

        public override async Task<IceCream> Find(int id)
        {
            return await DbContext.IceCreams.FindAsync(id);
        }

        public override async Task<IEnumerable<IceCream>> FindAll()
        {
            return await DbContext.IceCreams.ToListAsync();
        }

        public override async Task<IEnumerable<IceCream>> FindByCondition(Expression<Func<IceCream, bool>> expression)
        {
            return await DbContext.IceCreams.Where(expression).ToListAsync();
            
        }

        public override async Task Update(IceCream entity)
        {
            DbContext.IceCreams.Update(entity);
        }
    }
}
