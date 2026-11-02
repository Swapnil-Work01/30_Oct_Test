using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public interface INotifier
    {
        void SendNotification(string recipient, string message);
    }

    public class EmailNotifier : INotifier
    {
        public void SendNotification(string recipient, string message)
        {
            if (string.IsNullOrWhiteSpace(recipient))
            {
                Console.WriteLine("Recipient cannot be blank.");
                return;
            }

            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Message cannot be blank.");
                return;
            }

            Console.WriteLine("----- Email Notification -----");
            Console.WriteLine($"Recipient : {recipient}");
            Console.WriteLine($"Message   : {message}");
        }
    }

    public class SmsNotifier: INotifier
    {
        public void SendNotification(string recipient, string message)
        {
            if (string.IsNullOrWhiteSpace(recipient))
            {
                Console.WriteLine("Recipient cannot be blank.");
                return;
            }

            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Message cannot be blank.");
                return;
            }

            Console.WriteLine("----- SMS Notification -----");
            Console.WriteLine($"Recipient : {recipient}");
            Console.WriteLine($"Message   : {message}");
        }
    }
    public class Question32
    {
        public static void ProcessNotification(INotifier notifier, string recipient, string message)
        {
            notifier.SendNotification(recipient, message);
            Console.WriteLine();
        }

        public static void Runner()
        {
            INotifier emailNotifier = new EmailNotifier();
            INotifier smsNotifier = new SmsNotifier();

            ProcessNotification(emailNotifier, "abc@gmail.com", "Your order has been shipped.");

            ProcessNotification(smsNotifier, "9876543210", "OTP is 1234.");

            ProcessNotification(emailNotifier,"","Hello");

            ProcessNotification(smsNotifier,"9876543210","");
        }
    }
}
