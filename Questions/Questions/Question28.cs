using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class DeliveryService
    {
        virtual public double Charge(double distance)
        {
            if (distance < 0)
                throw new Exception("Distance cannot be negative.");

            return 0;
        }
    }

    public class StandardDelivery : DeliveryService
    {
        override public double Charge(double distance)
        {
            if (distance < 0)
                throw new Exception("Distance cannot be negative.");

            return 50 + (10 * distance);
        }
    }

    public class ExpressDelivery : DeliveryService
    {
        override public double Charge(double distance)
        {
            if (distance < 0)
                throw new Exception("Distance cannot be negative.");

            return 100 + (15 * distance);
        }
    }
    public class Question28
    {
        public static void Runner()
        {
            DeliveryService standard = new StandardDelivery();
            DeliveryService express = new ExpressDelivery();

            double[] distances = { 0, 5, 12 };

            Console.WriteLine("===== Delivery Charge Summary =====");

            foreach (double distance in distances)
            {
                Console.WriteLine($"Distance : {distance} km");
                Console.WriteLine($"Standard Delivery : Rs. {standard.Charge(distance)}");
                Console.WriteLine($"Express Delivery  : Rs. {express.Charge(distance)}");
                Console.WriteLine();
            }

            try
            {
                standard.Charge(-5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
