using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Question12
    {
        public static void Runner()
        {
            double MemStart = GC.GetAllocatedBytesForCurrentThread();
            string Attendence;
            for(int i = 0; i < 1000; i++)
            {
                Attendence = i + "th Attendence";
            }
            double Memend = GC.GetAllocatedBytesForCurrentThread();
            double Required = Memend - MemStart;
            Console.WriteLine($"For String {Required} bytes");

            MemStart = GC.GetAllocatedBytesForCurrentThread();
            StringBuilder StringBuilderr= new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                StringBuilderr.Append("Attendance");
            }

            Memend = GC.GetAllocatedBytesForCurrentThread();
            Required = Memend - MemStart;
            Console.WriteLine($"For String Builder {Required} bytes");
        }
    }
}

//Output
//For String 87744 bytes
//For String Builder 33176 bytes 
