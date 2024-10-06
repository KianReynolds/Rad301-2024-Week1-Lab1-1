using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Rad301_2024_Week1_Lab1_1.Classes;

namespace Rad301_2024_Week1_Lab1_1
{
    public class ProductModel
    {
        public List<Supplier> Suppliers { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public ProductModel() 
        {
            Suppliers = new List<Supplier>
            {
                new Supplier { SupplierID = 1, SupplierName = "ACME", Address1 = "Collooney", Address2 = "Sligo" },
            new Supplier { SupplierID = 2, SupplierName = "Swift Electric", Address1 = "Finglas", Address2 = "Dublin" }
            };

            Categories = new List<Category>
            {
            new Category { CategoryID = 1, Description = "Hardware" },
            new Category { CategoryID = 2, Description = "Electrical Appliances" }
            };

            Products = new List<Product>
            {
            new Product { ProductID = 1, Description = "9 Inch Nails", Quantity = 200, UnitPrice = 0.1M, CategoryID = 1 },
            new Product { ProductID = 2, Description = "9 Inch Bolts", Quantity = 120, UnitPrice = 0.2M, CategoryID = 1 },
            new Product { ProductID = 3, Description = "Chimney Hoover", Quantity = 10, UnitPrice = 100.3M, CategoryID = 2 },
            new Product { ProductID = 4, Description = "Washing Machine", Quantity = 7, UnitPrice = 399.5M, CategoryID = 2 }
            };

        }
        
    }
}
