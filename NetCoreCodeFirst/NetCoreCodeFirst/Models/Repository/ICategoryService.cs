using NetCoreCodeFirst.Models.Entity;
using System.Collections.Generic;

namespace NetCoreCodeFirst.Models.Repository
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
