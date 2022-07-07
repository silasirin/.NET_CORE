using Web.Models.Entity.Base;

namespace Web.Models.Entity
{
    public class Category : CoreEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
