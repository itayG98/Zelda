using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Zelda.DAL
{
    /// <summary>
    /// An interface of data repository with data context class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAllSortedBy(IComparer<T> comp);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        IQueryable<T> FindAll();
        T Find(string id);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
