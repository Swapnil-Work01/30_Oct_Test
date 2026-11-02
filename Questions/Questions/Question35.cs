using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail.Reporting;


//Alies
using SalesTicket = Retail.Sales.Ticket;
using SupportTicket = Retail.Support.Ticket;


namespace Retail
{
    namespace Sales
    {
        public class Ticket
        {
            public int TicketId;
            public double Amount;

            public Ticket(int ticketId, double amount)
            {
                TicketId = ticketId;
                Amount = amount;
            }
        }
    }

    namespace Support
    {
        public class Ticket
        {
            public int TicketId;
            public string Issue;

            public Ticket(int ticketId, string issue)
            {
                TicketId = ticketId;
                Issue = issue;
            }
        }
    }

    namespace Reporting
    {
        public class Report
        {
            public void PrintSalesTicket(SalesTicket ticket)
            {
                Console.WriteLine("=== Sales Ticket ===");
                Console.WriteLine($"Id : {ticket.TicketId}");
                Console.WriteLine($"Amount : {ticket.Amount}");
            }

            public void PrintSupportTicket(SupportTicket ticket)
            {
                Console.WriteLine("=== Support Ticket ===");
                Console.WriteLine($"Id : {ticket.TicketId}");
                Console.WriteLine($"Issue : {ticket.Issue}");
            }
        }
    }
}

namespace Questions
{
    public class Question35
    {
        public static void Runner()
        {
            SalesTicket salesTicket = new SalesTicket(101, 2500);

            SupportTicket supportTicket = new SupportTicket(201, "Printer Not Working");

            Report report = new Report();
            report.PrintSalesTicket(salesTicket);
            Console.WriteLine();
            report.PrintSupportTicket(supportTicket);
        }
    }
}
