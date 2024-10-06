using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2024_Week1_Lab1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var model = new ProductModel();

            var allCategories = model.Categories;

            var allProducts = model.Products;

            var lowStockProducts = model.Products.Where(p => p.Quantity <= 100).ToList();

            var highStockProducts = model.Products.Where(p => p.Quantity > 120).ToList();

            var totalValueProducts = model.Products.Select(p => new
            {
                p.Description,
                TotalValue = p.Quantity * p.UnitPrice
            }).ToList();

            var hardwareProducts = model.Products
                .Where(p => p.CategoryID ==1)
                .ToList();

            var suppliersProducts = from supplier in model.Suppliers
                                    join product in model.Products on supplier.SupplierID equals product.CategoryID
                                    orderby supplier.SupplierName
                                    select new { supplier.SupplierName, product.Description };

            Console.WriteLine("All Categories: ");
            foreach (var category in allCategories) Console.WriteLine(category.Description);

            Console.WriteLine("\nAll Products:");
            foreach (var product in allProducts) Console.WriteLine(product.Description);

            Console.ReadLine();
        }
    }
}
