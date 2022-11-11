using CoreAppFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoreAppFood.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context c = new Context();
        public List<T> CategoryList()
        {
            return c.Set<T>().ToList();
        }
        public void TAdd(T p)
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }
        public void TDelete(T p)
        {
            c.Set<T>().Remove(p);
            c.SaveChanges();
        }
        public void TUpdate(T p)
        {
            c.Set<T>().Update(p);
            c.SaveChanges();
        }
        public void GetCategory(int id)
        {
            c.Set<T>().Find(id);
        }
    }
}
