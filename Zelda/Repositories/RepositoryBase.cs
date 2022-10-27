using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Zelda.Models;

namespace Zelda.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">A type of object which has a DBSet <T> in the requested DBContext</typeparam>
    /// <typeparam name="K">The <T> primary key type</typeparam>
    /// <typeparam name="TDBContext">A class which inherit from EntityFrameWorkCore.DBContext</typeparam>
    public abstract class RepositoryBase<T, K, TDBContext> : IRepositoryBase<T, K, TDBContext> where T : class where TDBContext : DbContext
    {
        protected  TDBContext DbContext { get; set; }
        public RepositoryBase(TDBContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task SaveAsync() => await DbContext.SaveChangesAsync();
        public async Task Create(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
            await SaveAsync();
        }

        public async Task Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            await SaveAsync();
        }

        public async Task Update(T entity)
        {
            DbContext.Set<T>().Update(entity);
            await SaveAsync();
        }

        public async Task<T> Find(K id)
         => await DbContext.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> FindAll()
         => await DbContext.Set<T>().ToListAsync();

        public async Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        => await DbContext.Set<T>().Where(expression).ToListAsync();

    }
}
