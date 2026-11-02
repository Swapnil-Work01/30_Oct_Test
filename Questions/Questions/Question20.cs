using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string UserName { get; set; }
        private double _balance { get; set; }

        public double Balance
        {
            get { return _balance; }
        }

        public BankAccount(string AccountNumber, string UserName)
        {
            this.AccountNumber = AccountNumber;
            this.UserName = UserName;
            this._balance = 0;
        }

        public void Deposit(BankAccount bankAccount,double amt)
        {
            if (amt < 0)
            {
                Console.WriteLine("Please enter valid amount, request could not be procceded");
                return;
            }
            bankAccount._balance += amt;
            Console.WriteLine($"{amt} Rs is successfully credited into your accout ({bankAccount.AccountNumber}) total balance is {bankAccount.Balance} Rs");
        }

        public void Withdraw(BankAccount bankAccount,double amt)
        {
            if (amt < 0)
            {
                Console.WriteLine("Please enter valid amount, request could not be procceded");
                return;
            }else if(bankAccount.Balance<0 || bankAccount.Balance < amt)
            {
                Console.WriteLine("Insufficient account balance");
                return;
            }
            bankAccount._balance -= amt;
            Console.WriteLine($"{amt} Rs is successfully debited from your accout ({bankAccount.AccountNumber}) rememning balance is {bankAccount.Balance} Rs");

        }

    }

    public class Question20
    {
        public static void Runner()
        {
            BankAccount account1 = new BankAccount("ACC101", "Swapnil");
            BankAccount account2 = new BankAccount("ACC102", "Rahul");

            Console.WriteLine("===== Deposit Operations =====");

            account1.Deposit(account1, 5000);
            account2.Deposit(account2, 3000);

            Console.WriteLine();

            Console.WriteLine("===== Withdrawal Operations =====");

            account1.Withdraw(account1, 1500);
            account2.Withdraw(account2, 500);

            Console.WriteLine();

            Console.WriteLine("===== Independent Account Balances =====");

            account1.Deposit(account1, 1000);
            account2.Withdraw(account2, 1000);

            Console.WriteLine();

            Console.WriteLine("===== Validation Checks =====");

            account1.Deposit(account1, -100);

            account2.Withdraw(account2, 10000);

            // Invalid access example:
            // account1._balance = 50000;

            // Compiler Error:
            // '_balance' is inaccessible due to its protection level
            // because it is declared as private.
        }
    }
}
