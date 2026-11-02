using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Question02
    {
        public static void Runner()
        {
            int[] DailySales = { 12500, 9800, 15400, 8700, 19100, 16800, 11200 };
            Console.Write("Enter the daily sales target in Rs : ");
            int Target = Convert.ToInt32(Console.ReadLine());

            Report(DailySales, Target);
            Console.WriteLine("Total sale is : " + FindTotal(DailySales));
            FindAvg(DailySales);
            FindMin(DailySales);
            FindMax(DailySales);
        }

        public static void Report(int[] DailySales, int Target)
        {
            for(int i = 0;i<DailySales.Length;i++)
            {
                if (DailySales[i] > Target)
                {
                    Console.WriteLine($"Day {i+1} meet the daily targte of {Target} by doing sales of {DailySales[i]}");
                }
            }
        }

        public static int FindTotal(int[] DailySales)
        {
            int Total = 0;
            foreach (int sale in DailySales) Total += sale;
            return Total;
        }

        public static void FindAvg(int[] DailySales)
        {
            int Total = FindTotal(DailySales);
            Console.WriteLine("Avg sale is : " + Total/(DailySales.Length));
        }
        public static void FindMin(int[] DailySales)
        {
            int Min = int.MaxValue;
            foreach (int sale in DailySales)
            {
                if (sale < Min) Min = sale;
            }
            Console.WriteLine("Minimum sale is : " + Min);
        }

        public static void FindMax(int[] DailySales)
        {
            int Max = int.MinValue;
            foreach (int sale in DailySales)
            {
                if (sale > Max) Max = sale;
            }
            Console.WriteLine("Maximunm sale is : " + Max);
        }
    }
}


//Output
/*
    Enter the daily sales target in Rs : 9000
    Day 1 meet the daily targte of 9000 by doing sales of 12500    
    Day 2 meet the daily targte of 9000 by doing sales of 9800
    Day 3 meet the daily targte of 9000 by doing sales of 15400
    Day 5 meet the daily targte of 9000 by doing sales of 19100
    Day 6 meet the daily targte of 9000 by doing sales of 16800
    Day 7 meet the daily targte of 9000 by doing sales of 11200
    Total sale is : 93500                                  
    Avg sale is : 13357
    Minimum sale is : 8700
    Maximunm sale is : 19100
 */