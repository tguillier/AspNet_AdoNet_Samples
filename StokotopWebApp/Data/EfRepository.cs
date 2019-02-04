using StokotopWebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokotopWebApp.Data
{
    public class EfRepository<T> : IRepository<T>
        where T : class, new()
    {
        ApplicationDbContext context;

        public EfRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
