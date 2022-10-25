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

        public abstract T Create(T entity);
        public abstract T Delete(T entity);
        public abstract T Find(K id);
        public abstract IQueryable<T> FindAll();
        public abstract IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        public abstract T Update(T entity);

        public async Task SaveAsync() => await DbContext.SaveChangesAsync();
    }
}
