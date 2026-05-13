using System;

namespace ObjectOriented
{
    internal class BankAccountExample
    {
        public void Run()
        {
            BankAccount bank = new BankAccount();

            bank.AccountNumber = 101;
            bank.Name = "Sammy";
            bank.Balance = 5000;

            Console.WriteLine("Account Number: " + bank.AccountNumber);
            Console.WriteLine("Account Holder Name: " + bank.Name);
            Console.WriteLine("Account Balance: " + bank.Balance);

            bank.Deposit(500);
            Console.WriteLine("Balance after Deposit: " + bank.Balance);

            bank.Withdraw(200);
            Console.WriteLine("Balance after Withdraw: " + bank.Balance);

            bank.Withdraw(5000); 
            Console.WriteLine("Final Balance: " + bank.Balance);
        }
    }

    public class BankAccount
    {
        private string accountHolderName = string.Empty;
        private int accountId;
        private double balance;

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit failed: Amount must be greater than zero.");
                return;
            }

            balance += amount;
            Console.WriteLine("Deposit successful.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw failed: Amount must be greater than zero.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Withdraw failed: Not sufficient balance.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdraw successful.");
            }
        }

        public int AccountNumber
        {
            get { return accountId; }
            set { accountId = value; }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
                else
                {
                    balance = value;
                }
            }
        }

        public string Name
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }
    }
}
