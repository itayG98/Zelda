using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Zelda.Repositories
{
    public abstract class RepositoryBase<T,K,C> : IRepositoryBase<T,K,C> where T : class where C : DbContext
    {
        protected C DbContext { get; set; }
        protected RepositoryBase(C dbContext)
        {
            DbContext = dbContext;
        }
        public abstract Task<T> Find(K id);
        public abstract Task<IQueryable<T>> FindAll();
        public abstract Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression);
        public abstract Task Create(T entity);
        public abstract Task Delete(T entity);
        public abstract Task Update(T entity);
        public async Task SaveAsync() => await DbContext.SaveChangesAsync();
    }
}
