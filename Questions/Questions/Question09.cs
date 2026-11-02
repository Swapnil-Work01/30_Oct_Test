using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Question09
    {
        public static void Runner()
        {
            int Stock = 10;

            while (true)
            {
                Console.Write("Enter quentities to update : ");
                int Qty = Convert.ToInt32(Console.ReadLine());
                bool Done;
                string Responce = Adjustment(ref Stock, Qty,out Done);
                Console.WriteLine(Responce);
                if (Done) break;
            }
        }

        public static string Adjustment(ref int Stock, int Qty, out bool Done)
        {
            bool Valid;
            string Responce = null;
            Validator(Qty, out Valid);

            if (Valid)
            {
                Done = true;
                Stock = Qty;
                Responce = "Qty is valid and updated successfully";
            }
            else
            {
                Done = false;
                Responce = "Qty is invalid and cant updated";
            }
                return Responce;
        }

        public static void Validator(int Qty,out bool valid)
        {
            if (Qty >= 0) valid = true;
            else valid = false;
        }
    }
}

//Output 
/*
 Enter quentities to update : -1
Qty is invalid and cant updated 
Enter quentities to update : 10 
Qty is valid and updated successfully 
 */
