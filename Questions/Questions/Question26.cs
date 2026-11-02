using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Employee
    {
        public int EmpId;
        public string Name;
        public string Email;

        public Employee(int empId, string name, string email)
        {
            this.EmpId = empId;
            this.Name = name;
            this.Email = email;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Employee Id : {EmpId}");
            Console.WriteLine($"Name        : {Name}");
            Console.WriteLine($"Email       : {Email}");
        }
    }

    public class Manager : Employee
    {
        public string Department;
        public int TeamSize;

        public Manager(int empId, string name, string email, string department, int teamSize):base(empId, name, email)
        {

            if (teamSize <= 0) throw new Exception("Team size must be greater than 0.");
            this.Department = department;
            this.TeamSize = teamSize;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Department  : {Department}");
            Console.WriteLine($"Team Size   : {TeamSize}");
        }
    }
    public class Question26
    {
        public static void Runner()
        {
            Employee emp1 = new Employee(101, "Swapnil", "swapnil@gmail.com");
            Employee emp2 = new Employee(102, "Rahul", "rahul@gmail.com");
            Manager mgr1 = new Manager(201, "Vikas", "vikas@gmail.com", "Engineering", 10);
            Manager mgr2 = new Manager(202, "Namrata", "namrata@gmail.com", "Operations",15);

            Employee[] directory ={emp1, emp2, mgr1, mgr2};

            Console.WriteLine("===== Employee Directory =====");

            foreach (Employee employee in directory)
            {
                employee.Display();
                Console.WriteLine();
            }
        }
    }
}
