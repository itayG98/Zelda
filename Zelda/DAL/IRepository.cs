using Microsoft.EntityFrameworkCore;

namespace Zelda.DAL
{
    public interface IRepository <T>
    {
        public DbContext Context { get; set; }

        public IEnumerable<T> GetAll();

        public IEnumerable<T> GetAllSortedBy( IComparer<T> comp);
        public T Get(string id);
        public T Add(T entity);
        public T Update(T entity);
        public T Delete(T entity);
        public T Delete(string ID);

    }
}
