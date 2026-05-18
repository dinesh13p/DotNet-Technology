using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Dinesh Poudel", 100123);
            account.AccountType = AccountType.Saving;

            // Deposit money
            account.Deposit(5000.00);

            // Make a withdrawal
            account.Withdrawal(1500.00);

            // Display account information
            account.DisplayAccountInfo();
        }
    }
}