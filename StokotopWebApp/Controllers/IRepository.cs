using System.Collections.Generic;

namespace StokotopWebApp.Controllers
{
    public interface IRepository<T>
        where T : class, new()
    {
        T Find(int id);
        IEnumerable<T> FindAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(int id);
    }
}