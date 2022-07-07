namespace NetCoreCodeFirst.Models.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        //Mapping
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}