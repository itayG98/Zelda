using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Zelda.Repositories
{
    /// <summary>
    /// An interface of data repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K">Key type param of T</typeparam>
    /// <typeparam name="c">Key type param of the DBContext</typeparam>
    public interface IRepositoryBase<T,K,TDBContext> where T : class where  TDBContext : DbContext
    {
        //IQueryable<T> GetAllSortedBy(IComparer<T> comp);
        protected Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        protected Task<IEnumerable<T>> FindAllAsync();
        protected Task<T> FindAsync(K id);
        protected Task CreateAsync(T entity);
        protected Task UpdateAsync(T entity);
        protected Task DeleteAsync(T entity);
        public Task SaveAsync();

    }
}
