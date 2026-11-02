using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    abstract public class InsurancePolicy
    {
        public int PolicyNumber;
        public string CustomerName;

        public InsurancePolicy(int policyNumber, string customerName)
        {
            PolicyNumber = policyNumber;
            CustomerName = customerName;
        }

        abstract public double PremiumCalculation();
    }

    public class HealthPolicy : InsurancePolicy
    {
        public double BasePremium;
        public int CoveredMembers;

        public HealthPolicy(int policyNumber, string customerName, double basePremium, int coveredMembers) : base(policyNumber, customerName)
        {
            if (basePremium < 0)
                throw new Exception("Base premium cannot be negative");

            if (coveredMembers <= 0)
                throw new Exception("Covered members must be greater than 0");

            BasePremium = basePremium;
            CoveredMembers = coveredMembers;
        }

        public override double PremiumCalculation()
        {
            return BasePremium + (CoveredMembers * 500);
        }
    }

    public class MotorPolicy : InsurancePolicy
    {
        public double VehicleValue;

        public MotorPolicy( int policyNumber, string customerName, double vehicleValue) : base(policyNumber, customerName)
        {
            if (vehicleValue < 0)
                throw new Exception("Vehicle value cannot be negative");

            VehicleValue = vehicleValue;
        }

        public override double PremiumCalculation()
        {
            return VehicleValue * 0.03;
        }
}



    public class Question22
    {
        public static void Runner()
        {
            InsurancePolicy[] policies =
            {
                new HealthPolicy(101, "Swapnil", 5000, 4),
                new MotorPolicy(102, "Rahul", 800000)
            };

            Console.WriteLine("===== Premium Summary =====");

            foreach (InsurancePolicy policy in policies)
            {
                Console.WriteLine($"Policy Number : {policy.PolicyNumber}");
                Console.WriteLine($"Customer Name : {policy.CustomerName}");
                Console.WriteLine($"Premium : Rs. {policy.PremiumCalculation()}");
                Console.WriteLine();
            }
        }
    }
}
