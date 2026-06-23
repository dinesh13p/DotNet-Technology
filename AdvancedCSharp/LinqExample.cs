using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Product
    {
        public string Name;
        public double Price;
        public bool IsActive;
        public string Category;
        public int Stock;
    }
    internal class LinqExample
    {
        public void run()
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 120000.00, Category = "Electronics", IsActive = true, Stock = 50 },
                new Product { Name = "Smartphone", Price = 45000.00, Category = "Electronics", IsActive = true, Stock = 120 },
                new Product { Name = "Headphones", Price = 3500.00, Category = "Accessories", IsActive = true, Stock = 200 },
                new Product { Name = "Office Chair", Price = 15000.00, Category = "Furniture", IsActive = true, Stock = 0 },
                new Product { Name = "Gaming Mouse", Price = 2500.00, Category = "Accessories", IsActive = true, Stock = 150 },
                new Product { Name = "Monitor", Price = 28000.00, Category = "Electronics", IsActive = true, Stock = 40 },
                new Product { Name = "Keyboard", Price = 1800.00, Category = "Accessories", IsActive = false, Stock = 75 },
                new Product { Name = "Printer", Price = 22000.00, Category = "Office Equipment", IsActive = true, Stock = 25 },
                new Product { Name = "Tablet", Price = 38000.00, Category = "Electronics", IsActive = true, Stock = 60 },
                new Product { Name = "Webcam", Price = 4200.00, Category = "Accessories", IsActive = false, Stock = 90 }
            };

            var response = from product in products
                        where product.IsActive == true
                        orderby product.Price descending
                        select product.Name;

            foreach (var item in response)
            {
                //Console.WriteLine(item);
            }

            //var response1 = (from product in products)

            var response1 = from product in products
                            where product.Stock == 0
                            select product.Name;

            foreach (var item in response1)
            {
                //Console.WriteLine(item);
            }
            var response2 = from product in products
                            where product.Stock == 0
                            select new { product.Name, product.Price };

            foreach (var item in response2)
            {
                Console.WriteLine(item);
            }

            Func<Product, bool> predicate = (product) => product.IsActive;
            Func<Product, string> selectFunc = (product) => product.Name;
            Func<Product, string> selectFuncCate = (product) => product.Category;
            Func<Product, double> orderByFunc = (product) => product.Price;
            var response3 = from product in products.Where(predicate).OrderByDescending(orderByFunc);

        }
    }
}