
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(111111111, "chaitu");
            account.Deposit(30000);
            account.Withdraw(2000);

            Console.WriteLine("Account Number:" + account.AccountNo);
            Console.WriteLine("Account Holder Name:" + account.AccountHolderName);
            Console.WriteLine("Current Balance:" + account.Balance);
            Console.ReadKey();
        }
    }
}