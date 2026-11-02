using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Questions
{
    public class Question13
    {
        public static void Runner()
        {
            Console.Write("Enter name of customer with leading and traling spaces : ");
            string Name = Console.ReadLine();
            Console.Write("Enter phone with -  : ");
            string Phone = Console.ReadLine();
            Console.Write("Enter customer code in mixed cases : ");
            string CustomerCode = Console.ReadLine();

            CleanName(Name);
            CleanPhone(Phone);
            CleanCode(CustomerCode);
            SearchCustomerName(Name);
        }

        public static void CleanName(string Name)
        {
            string UpdatedName = Name.Trim().ToLower();
            
            Console.WriteLine("Cleaned customer name is : "+ UpdatedName);
        }

        public static void CleanCode(string CustomerCode)
        {
            CustomerCode = CustomerCode.Trim().ToUpper();
            Console.WriteLine("Cleaned customer Id is : " + CustomerCode);
        }

        public static void CleanPhone(string Phone)
        {
            Phone = Phone.Replace('-',' ').Trim();
            Console.WriteLine("Cleaned customer Phone is : " + Phone);
        }

        public static void SearchCustomerName(string Name)
        {
            Console.Write("Enter customer name to search - ");
            string Cname = Console.ReadLine();

            string[] arr = Name.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Trim();
            }
            if (Cname.ToLower().Equals(arr[0]))
            {
                Console.WriteLine("Name Matched ");
            }else
            {
                Console.WriteLine("Name not found ");
            }

        }
    }
}

//Output
//Enter name of customer with leading and traling spaces : Abc Pqr
//Enter phone with -  : 923-921-1829
//Enter customer code in mixed cases : Cust129QIo
//Cleaned customer name is : abc pqr
//Cleaned customer Phone is : 923 921 1829
//Cleaned customer Id is : CUST129QIO
//Enter customer name to search - Cde
//Name not found
