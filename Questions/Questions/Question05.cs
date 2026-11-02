using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Question05
    {
        public static void Runner()
        {
            int?[] Age = { 21, 23, null, 0 };
            int?[] BonusAmt = { null, 12000, 0, 20000 };
            DateOnly?[] JoiningDate = { new DateOnly(), new DateOnly(), null, new DateOnly() };

            Console.WriteLine("Bonus Report = ");
            BonusReport(BonusAmt);
            Console.WriteLine("Total bonus report = ");
            TotalBonus(BonusAmt);
            Console.WriteLine("Age updation for null value = ");
            Update(Age);
        }

        public static void BonusReport(int?[] BonusAmt)
        {
            for(int i = 0;i < BonusAmt.Length;i++)
            {
                if (BonusAmt[i] is null) Console.WriteLine($"Bonus is missing(null) for user {i+1}");
                else if (BonusAmt[i] > 0) Console.WriteLine($"Bonus is positive {BonusAmt[i]} for user {i + 1}");
                else if (BonusAmt[i] == 0) Console.WriteLine($"Bonus is zero {BonusAmt[i]} for user {i + 1}");
            }
        }

        public static void TotalBonus(int?[] BonusAmt)
        {
            int TotalBonus = 0;
            for (int i = 0; i < BonusAmt.Length; i++)
            {
                if (BonusAmt[i] is not null)
                {
                    TotalBonus += (int)BonusAmt[i];
                }
                
            }

            Console.WriteLine($"Total bonus amout is : {TotalBonus}");
        }

        public static void Update(int?[] Age)
        {
            int? age;
            while (true)
            {
                Console.Write("Enter age :");
                age = Convert.ToInt32(Console.ReadLine());

                if (age >= 0 && age is not null) break;
                else
                {
                    Console.WriteLine($"Please enter valid age (>0 and not null)");
                }
            }
            Age[GetNull(Age)] = age;

            Console.WriteLine("Age is updated at first null location !!");
            Console.WriteLine(string.Join(',',Age));

        }

        public static int GetNull(int?[] Age)
        {
            int index = 0;
            for(int i = 0; i < Age.Length; i++)
            {
                if (Age[i] is null) {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}

//Output
//Bonus Report =
//Bonus is missing(null) for user 1
//Bonus is positive 12000 for user 2
//Bonus is zero 0 for user 3
//Bonus is positive 20000 for user 4
//Total bonus report =
//Total bonus amout is : 32000
//Age updation for null value =
//Enter age :-1
//Please enter valid age (>0 and not null)
//Enter age :29
//Age is updated at first null location !!
//21,23,29,0

