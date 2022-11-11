using System.Collections.Generic;

namespace CoreAppFood.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Food> Foods { get; set; }
    }
}
