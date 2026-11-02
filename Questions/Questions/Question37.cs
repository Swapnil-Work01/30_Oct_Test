using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public interface IApprovalSummary
    {
        string GetSummary();
    }
    abstract public class LeavePolicy
    {
        public int EmployeeId;
        public string EmployeeName;

        public LeavePolicy(int employeeId, string employeeName)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
        }

        public abstract bool ValidateLeave(int days);

    }

    public class AnnualLeavePolicy : LeavePolicy, IApprovalSummary
    {
        public AnnualLeavePolicy(int employeeId, string employeeName) : base(employeeId, employeeName)
        {
        }

        public override bool ValidateLeave(int days)
        {
            if (days <= 0)
            {
                Console.WriteLine("Leave days must be greater than 0.");
                return false;
            }

            return days <= 20;
        }
        public string GetSummary()
        {
            return $"Annual Leave Policy - Employee: {EmployeeName}, Limit: 20 Days";
        }

    }

    public class SickLeavePolicy : LeavePolicy, IApprovalSummary
    {
        public SickLeavePolicy(int employeeId, string employeeName) : base(employeeId, employeeName)
        {
        }

        public override bool ValidateLeave(int days)
        {
            if (days <= 0)
            {
                Console.WriteLine("Leave days must be greater than 0.");
                return false;
            }

            return days <= 10;
        }

        public string GetSummary()
        {
            return $"Sick Leave Policy - Employee: {EmployeeName}, Limit: 10 Days";
        }
    }
    public class Question37
    {
        public static void Runner()
        {
            LeavePolicy annual = new AnnualLeavePolicy(101, "Swapnil");
            LeavePolicy sick = new SickLeavePolicy(102, "Rahul");
            int[] requests = { 0, 5, 25 };

            Console.WriteLine("===== Leave Validation =====");

            foreach (int days in requests)
            {
                Console.WriteLine($"Request: {days} Days");
                Console.WriteLine($"Annual Leave Approved: {annual.ValidateLeave(days)}");
                Console.WriteLine($"Sick Leave Approved: {sick.ValidateLeave(days)}");
            }

            Console.WriteLine("\n===== Approval Summaries =====");

            IApprovalSummary annualSummary = (IApprovalSummary)annual;
            IApprovalSummary sickSummary = (IApprovalSummary)sick;

            Console.WriteLine(annualSummary.GetSummary());
            Console.WriteLine(sickSummary.GetSummary());
        }
    }
}
