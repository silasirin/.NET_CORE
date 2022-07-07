using System.Collections.Generic;

namespace NetCoreCustomRoute.Models
{
    public class Category
    {
        public static List<Category> categories = new List<Category>
        {
            new Category{ID=1, CategoryName="Beverages"},
            new Category{ID=2, CategoryName="Condiments"},
            new Category{ID=3, CategoryName="Diary Products" },
            new Category{ID=4, CategoryName="Desserts" },
        };
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }
}
