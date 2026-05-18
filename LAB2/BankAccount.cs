using System;
using System.Collections.Generic;

namespace LAB2
{
    public enum AccountType
    {
        Generic,
        Current,
        Saving,
        Business
    }

    public class BankAccount
    {
        public static string BankName { get; private set; }

        static BankAccount()
        {
            BankName = "Global Trust Bank";
        }

        public string AccountName { get; set; }

        public long AccountNumber { get; }

        protected decimal Balance { get; set; }

        public AccountType AccountType { get; set; } = AccountType.Generic;

        public bool IsActive { get; } = true;

        private readonly List<string> _transactionHistory = new();
        public IReadOnlyList<string> TransactionHistory => _transactionHistory.AsReadOnly();

        public BankAccount(string accountName, long accountNumber)
        {
            AccountName = accountName;
            AccountNumber = accountNumber;
            Balance = 0.0m;
            AddLog($"Account created for {accountName} with Account Number: {accountNumber}");
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
                return;
            }

            decimal depositAmount = (decimal)amount;
            Balance += depositAmount;
            AddLog($"Deposited: Rs. {depositAmount:F2} | New Balance: Rs. {Balance:F2}");
            Console.WriteLine($"Successfully deposited Rs. {depositAmount:F2}");
        }

        public void Withdrawal(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
                return;
            }

            decimal withdrawalAmount = (decimal)amount;

            if (withdrawalAmount > Balance)
            {
                Console.WriteLine("Error: Insufficient funds for this withdrawal.");
                AddLog($"Failed Withdrawal Attempt: Rs. {withdrawalAmount:F2} | Reason: Insufficient funds");
                return;
            }

            Balance -= withdrawalAmount;
            AddLog($"Withdrawn: Rs. {withdrawalAmount:F2} | New Balance: Rs. {Balance:F2}");
            Console.WriteLine($"Successfully withdrawn Rs. {withdrawalAmount:F2}");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Bank Name: {BankName}");
            Console.WriteLine($"Account Holder: {AccountName}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Balance: {Balance:F2}");
            Console.WriteLine($"Status: {(IsActive ? "Active" : "Inactive")}");
            Console.WriteLine("\nTransaction History:");
            if (_transactionHistory.Count == 0)
                Console.WriteLine("No transactions.");
            else
                foreach (var transaction in _transactionHistory)
                    Console.WriteLine($"  {transaction}");
        }

        private void AddLog(string message)
        {
            _transactionHistory.Add($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
        }
    }
}