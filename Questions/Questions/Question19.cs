using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questions
{
    public class Registration
    {
        public static int StudentCounter = 0;

        public int Id { get; set; }
        public string Name { get; set; }

        public Registration(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            StudentCounter++;
        }
    }
    public class Question19
    {
        public static void Runner()
        {
            Registration reg1 = new Registration(1, "ABC");
            Registration reg2 = new Registration(2, "PQR");
            Registration reg3 = new Registration(3, "LNM");

            Console.WriteLine("===== Initial Registrations =====");
            Console.WriteLine($"reg1 -> Id: {reg1.Id}, Name: {reg1.Name}");
            Console.WriteLine($"reg2 -> Id: {reg2.Id}, Name: {reg2.Name}");
            Console.WriteLine($"reg3 -> Id: {reg3.Id}, Name: {reg3.Name}");

            Console.WriteLine($"Total Registrations Created: {Registration.StudentCounter}");

            
            Registration alias = reg1;

            Console.WriteLine("===== Before Update =====");
            Console.WriteLine($"reg1 Id: {reg1.Id}");
            Console.WriteLine($"alias Id: {alias.Id}");

            
            alias.Id = 10;
            alias.Name = "Updated ABC";

            Console.WriteLine("===== After Update Through Alias =====");
            Console.WriteLine($"reg1 -> Id: {reg1.Id}, Name: {reg1.Name}");
            Console.WriteLine($"alias -> Id: {alias.Id}, Name: {alias.Name}");

            
            Console.WriteLine($"\nTotal Registrations Created: {Registration.StudentCounter}");
        }
    }
}
