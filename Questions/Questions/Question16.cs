using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public struct Dimensions
    {
        public int Length;
        public int Width;
        public int Height;

        public Dimensions(int Length,int Width,int Height)
        {
            this.Length = Length;
            this.Width = Width;
            this.Height = Height;
        }
        public double Volume()
        {
            return Length * Width * Height;
        }
    }

    public class Parcel
    {
        public Dimensions size;
    }

    public class Question16
    {
        public static void Runner()
        {
            int Length;
            int Width;
            int Height;

            while (true)
            {
                Console.Write("Enter length :");
                Length = Convert.ToInt32(Console.ReadLine());
                if (Length > 0 ) break;
                else
                {
                    Console.WriteLine($"Please enter +ve length");
                }
            }

            while (true)
            {
                Console.Write("Enter width :");
                Width = Convert.ToInt32(Console.ReadLine());
                if (Width > 0) break;
                else
                {
                    Console.WriteLine($"Please enter +ve width");
                }
            }

            while (true)
            {
                Console.Write("Enter height :");
                Height = Convert.ToInt32(Console.ReadLine());
                if (Height > 0) break;
                else
                {
                    Console.WriteLine($"Please enter +ve height");
                }
            }

            Dimensions dimensions = new Dimensions(Length, Width, Height);
            Console.WriteLine("Volume is : "+dimensions.Volume());

            Dimensions dimensions1 = dimensions;
            dimensions1.Length = 100;
            Console.WriteLine("Dimention length is changed to 100 ");
            Console.WriteLine("Dimension length (Original remains unchanegd bcz structure is value type) = "+dimensions.Length);


            Dimensions dimensions2 = new Dimensions(1,2,3);
            Parcel parcel = new Parcel();
            parcel.size = dimensions2;

            Parcel parcel1 = new Parcel();
            parcel1 = parcel;

            parcel1.size.Length = 12;

            Console.WriteLine("Parcel.size.lenngth after updated by parcel1 to 12 is : "+parcel.size.Length);
            Console.WriteLine("Means value of length get changed for both variables bcz (class are referance tyes)");
        }
    }
}

//Output 
//Enter length :10
//Enter width :19
//Enter height :10
//Volume is : 1900
//Dimention length is changed to 100
//Dimension length (Original remains unchanegd bcz structure is value type) = 10

