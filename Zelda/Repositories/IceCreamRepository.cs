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
          =>  await DbContext.IceCreams.AddAsync(entity);

        public override async Task Delete(IceCream entity)
         =>   DbContext.IceCreams.Remove(entity);

        public override async Task<IceCream> Find(int id)
         => await DbContext.IceCreams.FindAsync(id);

        public override async Task<IEnumerable<IceCream>> FindAll()
         => await DbContext.IceCreams.ToListAsync();

        public override async Task<IEnumerable<IceCream>> FindByCondition(Expression<Func<IceCream, bool>> expression)
        => await DbContext.IceCreams.Where(expression).ToListAsync();

        public override async Task Update(IceCream entity)
        => DbContext.IceCreams.Update(entity);
    }
}
