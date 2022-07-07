using DAL.Models.Entity.Base;

namespace DAL.Models.Entity
{
    public class Product : CoreEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }


        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
