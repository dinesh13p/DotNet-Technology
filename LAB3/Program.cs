using System;

namespace BankAccountManagement
{
    class LAB3
    {
        static void Main(string[] args)
        {
            SavingsAccount sa1 = new SavingsAccount(
                "Dinesh Poudel",
                1001,
                5000
            );

            sa1.Deposit(2000);
            sa1.Withdraw(1500);
            sa1.ApplyInterest();
            sa1.DisplayAccountInfo();

            Console.WriteLine("\n--- Polymorphism Example ---");

            BankAccount account;

            account = new SavingsAccount(
                "Bahadur Sharma",
                2002,
                10000
            );

            account.Deposit(1000);
            account.Withdraw(2000);
            account.DisplayAccountInfo();

            Console.ReadKey();
        }
    }
}