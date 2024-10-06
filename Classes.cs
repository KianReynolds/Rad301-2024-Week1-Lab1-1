using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1_1
{
    public class Classes
    {
        public class Supplier
        {
            public int SupplierID {  get; set; }
            public string SupplierName { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
        }

        public class Category
        {
            public int CategoryID { get; set; }
            public string Description { get; set; }
        }

        public class Product
        {
            public int ProductID { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public int CategoryID { get; set; }
        }

        public class SupplierProducts
        {
            public int SupplierID { get; set; }
            public int ProductID { get; set; }
            public DateTime DateFirstOffered { get; set; }
        }
    }
}
