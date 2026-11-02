using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class RoomBooking
    {
        public string Room { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public string Organizer { get; set; }

        public RoomBooking(string room, DateTime startTime)
        {
            this.Room = room;
            this.StartTime = startTime;
            this.Duration = 30;
            this.Organizer = "Unassigned";
        }

        public RoomBooking(string room, DateTime startTime, int duration)
        {
            this.Room = room;
            this.StartTime = startTime;
            this.Duration = duration;
            this.Organizer = "Unassigned";
        }

        public RoomBooking(string room, DateTime startTime, int duration, string organizer)
        {
            if (string.IsNullOrWhiteSpace(room))
                throw new Exception("Room cannot be empty.");

            if (duration <= 0)
                throw new Exception("Duration must be greater than 0.");

            this.Room = room;
            this.StartTime = startTime;
            this.Duration = duration;
            this.Organizer = organizer;
        }

        public void Display()
        {
            Console.WriteLine($"Room      : {Room}");
            Console.WriteLine($"StartTime : {StartTime}");
            Console.WriteLine($"Duration  : {Duration} minutes");
            Console.WriteLine($"Organizer : {Organizer}");
            Console.WriteLine();
        }


    }
    public class Question23
    {
        public static void Runner()
        {
            RoomBooking booking1 = new RoomBooking("Conference Room A", DateTime.Now);

            RoomBooking booking2 = new RoomBooking("Conference Room B", DateTime.Now, 60);

            RoomBooking booking3 = new RoomBooking("Conference Room C", DateTime.Now, 90, "Swapnil");

            Console.WriteLine("===== Booking 1 =====");
            booking1.Display();

            Console.WriteLine("===== Booking 2 =====");
            booking2.Display();

            Console.WriteLine("===== Booking 3 =====");
            booking3.Display();
        }
    }
}
