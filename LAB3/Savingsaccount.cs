using System;

namespace BankAccountManagement
{
    class SavingsAccount : BankAccount
    {
        public const double InterestRate = 0.04;

        public SavingsAccount(string name, int accNo, double balance)
            : base(name, accNo, balance)
        {
        }

        public void ApplyInterest()
        {
            double interest = Balance * InterestRate;
            base.Deposit(interest);
            Console.WriteLine($"Interest Applied: Rs. {interest}");
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Interest Rate  : {InterestRate * 100}%");
        }
    }
}