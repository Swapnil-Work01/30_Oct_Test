using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class OrderLine
    {
        public string ItemName;
        public int Quantity;
        public double Price;
        public string Instruction;
    }
    public class RestaurantOrder
    {
        private List<OrderLine> orders = new List<OrderLine>();

        private Dictionary<string, double> menu = new Dictionary<string, double>()
            {
                { "Pizza", 250 },
                { "Burger", 120 },
                { "Pasta", 180 }
            };

        public void AddItem(string itemName)
        {
            AddItem(itemName, 1);
        }

        public void AddItem(string itemName, int quantity)
        {
            AddItem(itemName, quantity, null);
        }

        public void AddItem( string itemName, int quantity, string instruction)
        {
            if (!menu.ContainsKey(itemName))
            {
                Console.WriteLine($"Unknown Item : {itemName}");
                return;
            }

            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0.");
                return;
            }

            orders.Add(new OrderLine
            {
                ItemName = itemName,
                Quantity = quantity,
                Price = menu[itemName],
                Instruction = instruction
            });

            Console.WriteLine($"{itemName} added successfully.");
        }

        public void PrintBill()
        {
            double total = 0;

            Console.WriteLine("===== Order Summary =====");

            foreach (OrderLine order in orders)
            {
                double lineTotal = order.Price * order.Quantity;
                total += lineTotal;

                Console.WriteLine( $"{order.ItemName} x {order.Quantity} = Rs.{lineTotal}");

                if (!string.IsNullOrWhiteSpace(order.Instruction))
                {
                    Console.WriteLine($"Instruction : {order.Instruction}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Grand Total = Rs.{total}");
        }
    }
    public class Question27
    {
        public static void Runner()
        {
            RestaurantOrder order = new RestaurantOrder();

            order.AddItem("Pizza");
            order.AddItem("Burger", 2);
            order.AddItem("Pasta", 3, "Extra Cheese");
            order.AddItem("IceCream");
            order.AddItem("Pizza", -1);

            Console.WriteLine();

            order.PrintBill();
        }
    }
}
