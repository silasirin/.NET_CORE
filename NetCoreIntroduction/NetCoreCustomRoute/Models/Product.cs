using System.Collections.Generic;

namespace NetCoreCustomRoute.Models
{
    public class Product
    {
        public static List<Product> products = new List<Product>
        {
            new Product{ID=1, ProductName="Chai",UnitPrice= 18,CategoryID=1 },
            new Product{ID=2, ProductName="Chang",UnitPrice= 15, CategoryID=2 },
            new Product{ID=3, ProductName="Tofu",UnitPrice= 11,CategoryID=3 },
            new Product{ID=4, ProductName="Ikura",UnitPrice= 19,CategoryID=4 }
        };

        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }
    }
}
