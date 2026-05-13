using System;

namespace ObjectOriented
{
    internal class OverLoadingExample
    {
        public void run()
        {
            BillCalculator calculator = new BillCalculator();
            int bill = calculator.Calc(300, 10, 10);
            Console.WriteLine(bill);
        }
    }

    class Operation
    {
        public void Add()
        {
        }

        public void Add(int a)
        {
        }

        public void Add(int a, double b)
        {
        }

        public void Add(double a, int b)
        {
            Console.WriteLine($"{a} {b}");
        }
    }

    class BillCalculator
    {
        public int Calc(int price)
        {
            int bill = price;
            return bill;
        }

        public int Calc(int price, int quantity)
        {
            int bill = price * quantity;
            return bill;
        }

        public int Calc(int price, int quantity, int discount)
        {
            int bill = (price * quantity) - ((price * quantity * discount) / 100);
            return bill;
        }
    }
}