using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Question03
    {
        public static void Runner()
        {
            int[][] SalesData =
            {
                new int[]{ 12000, 9000, 5000, 7000 },
                new int[]{ 8000, 11000, 6000, 9500 },
                new int[]{ 15000, 7000, 8500, 4000 }
            };

            Console.WriteLine("Branch Totals and highest sales = ");
            TotalForEachBranch(SalesData);
            Console.WriteLine("Total for each category = ");
            TotalForEachCategory(SalesData);
            Console.WriteLine("Update data of any cell =");
            UpdateCell(SalesData);

        }

        public static void TotalForEachBranch(int[][] SalesData)
        {
            int Highest = int.MinValue;
            int BranchId = 0;
            for(int i = 0; i < SalesData.Length; i++)
            {
                int TotalForBranch = 0;
                for(int j = 0; j < SalesData[i].Length; j++)
                {
                    TotalForBranch += SalesData[i][j];
                }
                Console.WriteLine($"Total sales for branch {i+1} is {TotalForBranch}");
                if (TotalForBranch > Highest)
                {
                    Highest = TotalForBranch;
                    BranchId = i + 1;
                }
            }

            Console.WriteLine($"Highest sales is {Highest} done by branch {BranchId}");

        }

        public static void TotalForEachCategory(int[][] SalesData)
        {
            for(int i = 0; i < 4; i++)
            {
                int CategoryTotal = 0;
                for(int j = 0; j < SalesData.Length; j++)
                {
                    CategoryTotal += SalesData[j][i ];
                }
                Console.WriteLine($"Total sales category  {i + 1} is {CategoryTotal}");
            }
        }

        public static void UpdateCell(int[][] SalesData)
        {
            int row;
            int col;
            int val;
            while (true)
            {
                Console.Write("Enter row :");
                row = Convert.ToInt32(Console.ReadLine());
                if (row >= 0 && row < SalesData.Length) break;
                else
                {
                    Console.WriteLine($"Please enter valid row from (0 to {SalesData.Length})");
                }
            }

            while (true)
            {
                Console.Write("Enter col :");
                col = Convert.ToInt32(Console.ReadLine());

                if (col >= 0 && row < SalesData.Length) break;
                else
                {
                    Console.WriteLine($"Please enter valid row from (0 to {SalesData[0].Length})");
                }
            }

            while (true)
            {
                Console.Write("Enter val :");
                val = Convert.ToInt32(Console.ReadLine());

                if (val >= 0) break;
                else
                {
                    Console.WriteLine($"Please enter valid value greater than 0");
                }
            }

            SalesData[row][col] = val;
            Console.WriteLine($"{val} is seted successfully");

        }
    }
}

//Output
/*
 Branch Totals and highest sales =
 Total sales for branch 1 is 33000
Total sales for branch 2 is 34500
Total sales for branch 3 is 34500
Highest sales is 34500 done by branch 2
Total for each category =
Total sales category  1 is 35000
Total sales category  2 is 27000
Total sales category  3 is 19500
Total sales category  4 is 20500
Update data of any cell =
Enter row :-1
Please enter valid row from (0 to 3)
Enter row :1 
Enter col :-9
Please enter valid row from (0 to 4)  
Enter col :1  
Enter val :-20 
Please enter valid value greater than 0  
Enter val :12           
12 is seted successfully
 
 */
