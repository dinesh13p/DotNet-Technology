using System;

namespace BankAccountManagement
{
    class BankAccount
    {
        public string AccountHolderName { get; set; }
        public int AccountNumber { get; set; }

        protected double Balance;

        public BankAccount(string name, int accNo, double balance)
        {
            AccountHolderName = name;
            AccountNumber = accNo;
            Balance = balance;
        }

        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: Rs. {amount}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: Rs. {amount}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine("\n---- Account Information ----");
            Console.WriteLine($"Account Holder : {AccountHolderName}");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Balance        : Rs. {Balance}");
        }
    }
}