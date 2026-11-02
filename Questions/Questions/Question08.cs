using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{

    public class CardPayment
    {
        public string PaymentMode = "Card";
    }

    public class WalletPayment
    {
        public string PaymentMode = "Wallet";
    }
    public class Question08
    {
        public static void Runner()
        {
            dynamic?[] arr = { new CardPayment(), new WalletPayment(), "Unrelated", null };

            foreach(dynamic? obj in arr)
            {
                if (obj is null)
                {
                    Console.WriteLine("Current object is null");
                }
                else if (obj is CardPayment)
                {
                    CardPayment card = obj as CardPayment;
                    Console.WriteLine($"I am from Card Payemnt class : My member is Payment Mode = {card.PaymentMode}");
                }
                else if (obj is WalletPayment)
                {
                    WalletPayment payment = obj as WalletPayment;
                    Console.WriteLine($"I am from Wallet Payemnt class : My member is Payment Mode = {payment.PaymentMode}");
                }
                else if (obj is string)
                {
                    string unrelated = obj as string;
                    Console.WriteLine($"I am unrelated string =  {unrelated}");
                }
            }

        }
    }
}
