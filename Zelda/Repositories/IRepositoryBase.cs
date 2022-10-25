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
        protected IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        protected IQueryable<T> FindAll();
        protected T Find(K id);
        protected T Create(T entity);
        protected T Update(T entity);
        protected T Delete(T entity);
        public Task SaveAsync();

    }
}
