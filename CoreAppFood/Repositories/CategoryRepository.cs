using CoreAppFood.Data.Models;

namespace CoreAppFood.Repositories
{
    public class CategoryRepository
    {
        Context c = new Context();

        public void FoodAdd(Food f)
        {
            c.Foods.Add(f);
            c.SaveChanges();
        }

        public void FoodRemove()
        {

        }
    }
}
