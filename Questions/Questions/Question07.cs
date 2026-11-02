using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Shipment
    {
        public int TrackingId;
        public bool Status;

    }

    public class Question07
    {
        public static void Runner()
        {
            var Payload1 = new Shipment();

            Payload1.TrackingId = 12;
            Payload1.Status = false;

            Console.WriteLine("Payload 1");
            Console.WriteLine($"Tracking Id = {Payload1.TrackingId}");
            Console.WriteLine($"Status = {Payload1.Status}");

            Shipment Payload2= new Shipment();
            Payload2.TrackingId = 1202;

            Console.WriteLine("Payload 2");
            Console.WriteLine($"Tracking Id = {Payload2.TrackingId}");
        }
    }
}
