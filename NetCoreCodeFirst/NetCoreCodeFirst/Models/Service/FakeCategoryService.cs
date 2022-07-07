using NetCoreCodeFirst.Models.Entity;
using NetCoreCodeFirst.Models.Repository;
using System.Collections.Generic;

namespace NetCoreCodeFirst.Models.Service
{
    public class FakeCategoryService: ICategoryService
    {
        public List<Category> categories = new List<Category>
        {
            new Category{ID=1,CategoryName="Test Giyim"},
            new Category{ID=2,CategoryName="Test Teknoloji"},
        };

        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
