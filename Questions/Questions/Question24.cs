using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class ExportTracker
    {
        public int Id;
        public ExportTracker(int id)
        {
            Id = id;
            Console.WriteLine($"Constructor called for Tracker {Id}");
        }

        ~ExportTracker()
        {
            Console.WriteLine($"Finalizer called for Tracker {Id}");
        }
    }
    public class Question24
    {
        public static void Runner()
        {
            Console.WriteLine("===== Creating Short-Lived Objects =====");

            for (int i = 1; i <= 5; i++)
            {
                ExportTracker tracker = new ExportTracker(i);
            }
            Console.WriteLine();

            Console.WriteLine("===== Writing Report File =====");

            using (StreamWriter writer = new StreamWriter("ExportReport.txt"))
            {
                writer.WriteLine("Export Report");
                writer.WriteLine($"Generated At: {DateTime.Now}");
                writer.WriteLine("Export completed successfully.");
            }

            Console.WriteLine("Report file written and closed.");
            Console.WriteLine();

            Console.WriteLine("===== Optional GC Experiment =====");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Garbage collection requested.");
            Console.WriteLine();
            Console.WriteLine("Program finished.");
        }
    }
}
