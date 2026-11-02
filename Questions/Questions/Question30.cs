using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class LegacyReport
    {
        public void Display()
        {
            Console.WriteLine("Display from legacy report class");
        }

        virtual public void Show()
        {
            Console.WriteLine("Show method from legacy report class");
        }
    }

    public class DashboardReport: LegacyReport
    {
        public new void Display()
        {
            Console.WriteLine("Display from dashboard report class");
        }

        override public void Show()
        {
            Console.WriteLine("Show method from dashboard report class");
        }
    }
    public class Question30
    {
        public static void Runner()
        {
            DashboardReport dashboard = new DashboardReport();

            LegacyReport legacyRef = dashboard as LegacyReport;

            Console.WriteLine("===== Method Hiding (new) =====");
            dashboard.Display();

            legacyRef.Display();

            Console.WriteLine();

            Console.WriteLine("===== Method Overriding (override) =====");

            dashboard.Show();
            legacyRef.Show();
        }
    }
}
