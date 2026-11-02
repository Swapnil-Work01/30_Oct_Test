using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();

    }

    public interface IMultiFunctionDevice:IPrinter, IScanner
    {

    }

    public class PrinterDevice : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }

    public class MultiFunctionDevice : IMultiFunctionDevice
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }
    public class Question33
    {
        public static void UsePrinter(IPrinter printer)
        {
            printer.Print();
        }

        public static void UseScanner(IScanner scanner)
        {
            scanner.Scan();
        }

        public static void UseMultiFunctionDevice(IMultiFunctionDevice device)
        {
            device.Print();
            device.Scan();
        }

        public static void Runner()
        {
            PrinterDevice printer = new PrinterDevice();
            MultiFunctionDevice mfd = new MultiFunctionDevice();

            Console.WriteLine("===== Printer =====");
            UsePrinter(printer);

            Console.WriteLine();

            Console.WriteLine("===== Multi Function Device =====");
            UsePrinter(mfd);
            UseScanner(mfd);
            UseMultiFunctionDevice(mfd);

            //IScanner scanner = new PrinterDevice();
        }
    }
}
