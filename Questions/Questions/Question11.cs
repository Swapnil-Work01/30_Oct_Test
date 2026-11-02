using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Customer
    {
        public string Name;

        public Customer(string Name)
        {
            this.Name = Name;
        }
    }
    public class Question11
    {
        public static void Runner()
        {
            Customer customer1 = new Customer("A");
            Customer customer2 = new Customer("A");
            Customer customer3 = customer1;

            Console.WriteLine("customer1.Name = "+customer1.Name);
            Console.WriteLine("customer2.Name = "+customer2.Name);
            Console.WriteLine("customer3.Name = "+customer3.Name);
            Console.WriteLine("customer1==customer2 -->" + (customer1==customer2));
            Console.WriteLine("customer1.Equals(customer2) -->"+customer1.Equals(customer2));
            Console.WriteLine("customer1.Name.Equals(customer2.Name) -->" + customer1.Name.Equals(customer2.Name));
            Console.WriteLine("(customer1==customer3) -->" + (customer1==customer3));

            string s = new string("A");
            Console.WriteLine("string s = "+s);
            Console.WriteLine("s.Equals(customer1.Name) -->" + s.Equals(customer1.Name));
            Console.WriteLine("s == customer1.Name -->" + (s==customer1.Name));


            // == check referance equality
            // .Equals() check logical equivalance
            // object created using new keyword occupies new memory in heap
        }
    }
}

//Output
/*
 customer1.Name = A
customer2.Name = A 
customer3.Name = A  
customer1==customer2 -->False 
customer1.Equals(customer2) -->False
customer1.Name.Equals(customer2.Name) -->True  
(customer1==customer3) -->True   
string s = A        
s.Equals(customer1.Name) -->True
s == customer1.Name -->True 
 */