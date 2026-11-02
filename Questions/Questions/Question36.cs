using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{

    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string code, string name, string category, double price, int quantity)
        {
            Code = code;
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }
    }

    public class Question36
    {
        public static void Runner()
        {
            Product[] products =
            {
                new Product("P101", "Laptop", "Electronics", 50000, 5),
                new Product("P102", "Mouse", "Electronics", 500, 20),
                new Product("P103", "Chair", "Furniture", 3000, 10)
            };

            var dashboardData = products.Select(p => new
            {
                p.Name,
                p.Category,
                InventoryValue = p.Price * p.Quantity
            });

            double totalInventoryValue = 0;

            Console.WriteLine("===== Sales Dashboard =====");

            foreach (var item in dashboardData)
            {
                Console.WriteLine($"Name            : {item.Name}");
                Console.WriteLine($"Category        : {item.Category}");
                Console.WriteLine($"Inventory Value : Rs. {item.InventoryValue}");
                Console.WriteLine();

                totalInventoryValue += item.InventoryValue;
            }

            Console.WriteLine($"Total Inventory Value = Rs. {totalInventoryValue}");

            //dashboardData.First().Name = "New Laptop";

            // Compile Error:
            // Property or indexer 'Name' cannot be assigned to.
            // Anonymous type properties are read-only.
        }
    }
}
