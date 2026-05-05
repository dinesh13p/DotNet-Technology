using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented
{
    internal class BankAccountExample
    {
        public void run()
        {
            BankAccount bank=new BankAccount();
            bank.AccountNumber= 1;
            bank.Name = "suman";
            bank.Balance = 1000;
            Console.WriteLine("Account Number:"+bank.AccountNumber);
            Console.WriteLine("Account Holder Name:" + bank.Name);
            Console.WriteLine("Account Holder Balance:" + bank.Balance);

            bank.Deposit(500);                                         
            Console.WriteLine("Balance after Deposit:" + bank.Balance);

            bank.WithDraw(200);                                        
            Console.WriteLine("Balance after Withdraw:" + bank.Balance);

            bank.WithDraw(5000);
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
                Console.WriteLine(" Deposit failed: Amount must be greater than zero.");
                return;
            }
            else
            {
                balance += amount;

            }
        }

        public void WithDraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw failed:Amount must be greater than zero");
            }else if (amount>balance)
            {
                Console.WriteLine("Withdraw failed:Not sufficient amount");
            }
            else { 
            balance-= amount;
            }
        }

        public int AccountNumber
        {
            get { return accountId; }
            set { accountId=value;}
        }

        public double Balance
        {

            get { return balance;}
            set {
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
            get { return accountHolderName;}
            set { accountHolderName=value;}
        }
    }

}
