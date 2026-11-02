using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /// <summary>
    /// Q01 Invoice value exchange
    /// A billing component receives invoice values through object variables.
    /// </summary>
    public class Question01
    {
       
        public static void Runner()
        {
            object BillingNo = 1001;
            object Total = 2499.50m;
            object PaidStatus = true;

            Billing(BillingNo, Total, PaidStatus);
        }
        public static void Billing(object BillingNo, object Total, object PaidStatus)
        {
            int IntBillingNo = (int) BillingNo;
            decimal DecimalTotal = (decimal) Total;
            bool BoolPaidStatus = (bool)PaidStatus;

            Console.WriteLine($"Billing no in int:{IntBillingNo}");
            Console.WriteLine($"Total in decimal:{DecimalTotal}");
            Console.WriteLine($"PaidStatus in bool:{BoolPaidStatus}");
            Console.WriteLine("Error demonstration :");
            Console.WriteLine("when the boxed invoice number is treated as a long instead of its original type");

            try {
            long TestBillingNo = (long)BillingNo;
            }catch(InvalidCastException e)
            {
                Console.WriteLine("Exception occure : "+e.GetType());
            }
        }
    }

    //Output
    /*
        Billing no in int:1001
        Total in decimal:2499.50
        PaidStatus in bool:True
        Error demonstration :
        when the boxed invoice number is treated as a long instead of its original type
        Exception occure : System.InvalidCastException
    */
}
