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
    public interface IRepositoryBase<T,K,C> where T : class where C : DbContext
    {
        //IQueryable<T> GetAllSortedBy(IComparer<T> comp);
        protected Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression);
        protected Task<IQueryable<T>> FindAll();
        protected Task<T> Find(K id);
        protected Task Create(T entity);
        protected Task Update(T entity);
        protected Task Delete(T entity);
        public Task SaveAsync();

    }
}
