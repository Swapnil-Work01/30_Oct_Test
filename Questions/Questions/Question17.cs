using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public enum OrderStatus
    {
        Pending, 
        Packed, 
        Shipped, 
        Delivered,
        Cancelled
    }

    public class Order
    {
        public int Id;
        public OrderStatus Status;

        public Order(int Id, OrderStatus Status)
        {
            this.Id = Id;
            this.Status = Status;
        }
    }
    public class Question17
    {
        public static void Runner()
        {
            Order o1 = new Order(1, OrderStatus.Pending);
            Order o2 = new Order(2, OrderStatus.Packed);
            Order o3 = new Order(3, OrderStatus.Shipped);
            Order o4 = new Order(4, OrderStatus.Delivered);
            Order o5 = new Order(5, OrderStatus.Cancelled);

            List<Order> Orders = new List<Order>();
            Orders.Add(o1);
            Orders.Add(o2);
            Orders.Add(o3);
            Orders.Add(o4);
            Orders.Add(o5);

            while (true)
            {
                Console.WriteLine("========= Menu ========");
                Console.WriteLine("1. View all orders");
                Console.WriteLine("2. Update order status");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice : ");
                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("-----------All orders data is------------");
                        foreach (Order order in Orders)
                        {
                            PrintOrder(order);
                        }
                        break;
                    case 2:
                        Console.Write("Enter Order Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter New Status: ");
                        string statusInput = Console.ReadLine();

                        if (!Enum.TryParse(statusInput, true, out OrderStatus newStatus))
                        {
                            Console.WriteLine("Undefined status.");
                            break;
                        }

                        ChangeOrderStatus(id, newStatus, Orders);

                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Please enter valid choice!!");
                        break;
                }
            }

        }

        public static void PrintOrder(Order o)
        {
            Console.WriteLine("=========== Order ============");
            Console.WriteLine($"Order Id : {o.Id}");
            Console.WriteLine($"Order status : {o.Status}");
        }

        public static void ChangeOrderStatus(int id,OrderStatus newStatus, List<Order> orders)
        {
            Order order = GetOrder(orders, id);
            if(order == null)
            {
                Console.WriteLine("Order id is invalid ");
                return;
            }

            Console.WriteLine($"Attempting transition: {order.Status} -> {newStatus}");

            if (CanTransition(order.Status, newStatus))
            {
                order.Status = newStatus;
                Console.WriteLine("Status updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid transition.");
            }
        }

        public static Order GetOrder(List<Order> orders, int id)
        {
            Order order = null;
            for(int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Id == id)
                {
                    order = orders[i];
                    break;
                }
            }
            return order;
        }

        public static bool CanTransition(OrderStatus currentStatus, OrderStatus newStatus)
        {
            switch (currentStatus)
            {
                case OrderStatus.Pending:
                    return newStatus == OrderStatus.Packed ||
                           newStatus == OrderStatus.Cancelled;

                case OrderStatus.Packed:
                    return newStatus == OrderStatus.Shipped ||
                           newStatus == OrderStatus.Cancelled;

                case OrderStatus.Shipped:
                    return newStatus == OrderStatus.Delivered;

                case OrderStatus.Delivered:
                case OrderStatus.Cancelled:
                    return false;

                default:
                    return false;
            }
        }
    }
}
