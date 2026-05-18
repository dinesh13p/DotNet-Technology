using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class OperatorOverloadingExample
    {
        public void Run()
        {

            //// Creating objects
            //Marks marks1 = new Marks(75);
            //Marks marks2 = new Marks(15);

            //// Object + Object
            //double total = marks1 + marks2;
            //Console.WriteLine("Total Marks: " + total);

            //// Object + double
            //double graceTotal = marks1 + 5;
            //Console.WriteLine("Marks after grace: " + graceTotal);

            //// double + Object
            //double anotherGrace = 10 + marks2;
            //Console.WriteLine("Another grace total: " + anotherGrace);

            var usd1 = new Money(2, "USD");
            var usd2 = new Money(10, "USD");
            var usd3 = new Money(30, "USD");

            var usdsum = usd2 + usd1;

            var usdMinus = usd3 + usdsum;
            var npr = usdMinus.Amount * 152;
            Console.WriteLine(" USD MINUS = "  + usdMinus.Amount);


        }
    }

    class Marks {

        public double Score;
        public Marks(double score) {
            Score = score;
        }

        public static double operator +(Marks marks1, Marks marks2) {
            return marks1.Score + marks2.Score;
        }

        public static double operator +(Marks marks, double grace)
        {
            return marks.Score + grace;
        }

        // double + Marks
        public static double operator + (double grace, Marks marks)
        {
            return grace + marks.Score;
        }

    }
    class Money
    {
        public decimal Amount;
        public string Currency;
        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }


        public static Money operator +(Money money1, Money money2)
        {
            if (money1.Currency == money2.Currency && money2.Amount > money1.Amount)
            {
                decimal output = money1.Amount + money2.Amount;
                return new Money(output, money1.Currency);
            }
            else
            {
                return money1;
            }


        }
        public static Money operator -(Money money1, Money money2)
        {
            if (money1.Currency == money2.Currency && money2.Amount > money1.Amount)
            {
                decimal output = money2.Amount - money1.Amount;
                return new Money(output, money1.Currency);
            }
            else
            {
                return money1;
            }
        }
    }
}