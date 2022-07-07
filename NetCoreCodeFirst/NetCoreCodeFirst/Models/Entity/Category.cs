using System.Collections.Generic;

namespace NetCoreCodeFirst.Models.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        //Mapping
        public virtual List<Product> Product { get; set; }
    }
}
