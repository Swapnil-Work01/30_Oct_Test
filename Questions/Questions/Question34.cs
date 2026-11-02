using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public interface IStockItem
    {
        int ItemCode { get; }
        double UnitPrice { get; set; }
        int Quantity { get; }
    }

    public class GroceryItem : IStockItem
    {
        public int ItemCode { get; }

        private double _unitPrice;
        public double UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price cannot be negative.");
                }
                _unitPrice = value;
            }
        }

        public int Quantity { get; private set; }

        public GroceryItem(int itemCode, double unitPrice, int quantity)
        {
            if (unitPrice < 0)
                throw new Exception("Price cannot be negative.");

            if (quantity < 0)
                throw new Exception("Quantity cannot be negative.");

            ItemCode = itemCode;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public void AddStock(int qty)
        {
            if (qty < 0)
                throw new Exception("Invalid stock.");

            Quantity += qty;
        }

        public void RemoveStock(int qty)
        {
            if (qty < 0 || qty > Quantity)
                throw new Exception("Invalid stock adjustment.");

            Quantity -= qty;
        }

    }

    public class HardwareItem : IStockItem
    {
        public int ItemCode { get; }

        private double _unitPrice;
        public double UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (value < 0)
                    throw new Exception("Price cannot be negative.");

                _unitPrice = value;
            }
        }

        public int Quantity { get; private set; }

        public HardwareItem(int itemCode, double unitPrice, int quantity)
        {
            if (unitPrice < 0)
                throw new Exception("Price cannot be negative.");

            if (quantity < 0)
                throw new Exception("Quantity cannot be negative.");

            ItemCode = itemCode;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public void AddStock(int qty)
        {
            if (qty < 0)
                throw new Exception("Invalid stock.");

            Quantity += qty;
        }

        public void RemoveStock(int qty)
        {
            if (qty < 0 || qty > Quantity)
                throw new Exception("Invalid stock adjustment.");

            Quantity -= qty;
        }
    }
    public class Question34
    {
        public static void Runner()
        {
            GroceryItem grocery = new GroceryItem(101, 50, 100);
            HardwareItem hardware = new HardwareItem(201, 250, 25);
            IStockItem[] items = {grocery, hardware};

            Console.WriteLine("===== Initial Stock =====");

            foreach (IStockItem item in items)
            {
                Console.WriteLine($"Code: {item.ItemCode}, Price: {item.UnitPrice}, Qty: {item.Quantity}");
            }

            Console.WriteLine();

            IStockItem stockRef = grocery;
            stockRef.UnitPrice = 60;

            Console.WriteLine($"Updated Grocery Price = {stockRef.UnitPrice}");
            Console.WriteLine();

            Console.WriteLine("===== After Price Update =====");
            foreach (IStockItem item in items)
            {
                Console.WriteLine($"Code: {item.ItemCode}, Price: {item.UnitPrice}, Qty: {item.Quantity}");
            }

            // stockRef.Quantity = 500;
        }
    }
}
