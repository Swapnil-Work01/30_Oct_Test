using System.Numerics;
using System.Xml.Linq;

namespace Question21FirstApp
{
    public class Payroll
    {
        internal int Id = 10;
        protected string Name = "Abc";
        protected internal int Salary = 50000;

        private string _email = "abc@gmail.com";
        public string Phone = "928239109201";
    }

    public class Employee : Payroll
    {
        public void PrintData()
        {
            Console.WriteLine($"Employee Id {Id}");
            Console.WriteLine($"Employee Name {Name}");
            Console.WriteLine($"Employee Salary {Salary}");
            //Console.WriteLine($"Employee Email {_email}");
            Console.WriteLine("Cant access private property email in derived class");
            Console.WriteLine($"Employee Phone {Phone}");

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Accessibility in derived class of same assembly");
            employee.PrintData();

            Console.WriteLine("Accessibility in unrelated class of same assembly");
            Payroll payroll = new Payroll();
            Console.WriteLine($"Employee Id {payroll.Id}");
            //Console.WriteLine($"Employee Name {payroll.Name
            Console.WriteLine($"Cant access Name because protected member only accessible in related class");
            Console.WriteLine($"Employee Salary {payroll.Salary}");
            Console.WriteLine("Cant access private property email in unrelated class");
            Console.WriteLine($"Employee Phone {payroll.Phone}");
        }
    }
}
