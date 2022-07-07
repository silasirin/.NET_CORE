using NetCoreCodeFirst.Models.Context;
using NetCoreCodeFirst.Models.Entity;
using NetCoreCodeFirst.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreCodeFirst.Models.Service
{
    
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
