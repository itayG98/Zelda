using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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
        protected TDBContext DbContext { get; set; }
        public RepositoryBase(TDBContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task SaveAsync() => await DbContext.SaveChangesAsync();
        public async Task CreateAsync(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
            await SaveAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            await SaveAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            DbContext.Set<T>().Update(entity);
            await SaveAsync();
        }

        public async Task<T> FindAsync(K id)
         => await DbContext.Set<T>().FindAsync(id);
        public T Find(K id) =>
            DbContext.Set<T>().FirstOrDefault(x =>x.Equals(x));

        public async Task<IEnumerable<T>> FindAllAsync()
         => await DbContext.Set<T>().ToListAsync();
        public IEnumerable<T> FindAll()
         => DbContext.Set<T>().ToList();

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        => await DbContext.Set<T>().Where(expression).ToListAsync();

    }
}
