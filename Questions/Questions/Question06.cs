using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Question06
    {
        public static void Runner()
        {
            var ItemCode = 9103;
            var Quantity = 12;
            var UnitPrice = 99.9f;
            //var[] Quentities = { 10, 2, 3, 4, 5 };


            if(ItemCode is int) Console.WriteLine("var ItemCode = 9103; is int type");
            if(Quantity is int) Console.WriteLine("var Quantity = 12; is int type");
            if(UnitPrice is float) Console.WriteLine("var UnitPrice = 99.9; is float type");

            //Quentity = 9.9f; //gives compile time error that flot cant converted into int

            Quantity = 11;
            Console.WriteLine($"Quantity after update is {Quantity}");
        }
    }
}

//Output
/*
 var ItemCode = 9103; is int type
var Quantity = 12; is int type
var UnitPrice = 99.9; is float type
Quantity after update is 11 
 */
