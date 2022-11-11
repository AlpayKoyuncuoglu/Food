using CoreAppFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoreAppFood.Repositories
{
    public class FoodRepository
    {
        Context c = new Context();
        public List<Category> CategoryList()
        {
            return c.Categories.ToList();
        }
        public void CategoryAdd(Category ct)
        {
            c.Categories.Add(ct);
            c.SaveChanges();
        }
        public void CategoryDelete(Category ct)
        {
            c.Categories.Remove(ct);
            c.SaveChanges();
        }
        public void CategoryUpdate(Category ct)
        {
            c.Categories.Update(ct);
            c.SaveChanges();
        }
        public void GetCategory(int id)
        {
            c.Categories.Find(id);
        }
    }
}
