using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public sealed class PaymentReceipt
    {
        public string ReceiptNumber { get; }
        public double Amount { get; }
        public DateTime CreationTime { get; }

        public PaymentReceipt(string receiptNumber, double amount)
        {
            if (string.IsNullOrWhiteSpace(receiptNumber))
                throw new Exception("Receipt number cannot be empty.");

            if (amount < 0)
                throw new Exception("Amount cannot be negative.");

            ReceiptNumber = receiptNumber;
            Amount = amount;
            CreationTime = DateTime.Now;
        }
    }

    //public class PremiumReceipt: PaymentReceipt
    //{

    //}

    public class Question31
    {
        public static void Runner()
        {
            PaymentReceipt receipt1 = new PaymentReceipt("R001", 5000);
            PaymentReceipt receipt2 = new PaymentReceipt("R002", 7500);

            Console.WriteLine("===== Receipt 1 =====");
            PrintReceipt(receipt1);

            Console.WriteLine("===== Receipt 2 =====");
            PrintReceipt(receipt2);
        }

        public static void PrintReceipt(PaymentReceipt receipt)
        {
            Console.WriteLine($"Receipt Number : {receipt.ReceiptNumber}");
            Console.WriteLine($"Amount         : Rs. {receipt.Amount}");
            Console.WriteLine($"Created On     : {receipt.CreationTime}");
            Console.WriteLine();
        }
    }
}
