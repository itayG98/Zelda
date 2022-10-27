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
        protected Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression);
        protected Task<IEnumerable<T>> FindAll();
        protected Task<T> Find(K id);
        protected Task Create(T entity);
        protected Task Update(T entity);
        protected Task Delete(T entity);
        public Task SaveAsync();

    }
}
