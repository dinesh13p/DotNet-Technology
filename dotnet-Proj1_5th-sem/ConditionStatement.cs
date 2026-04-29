using System;

namespace dotnettutorials
{
    internal class ConditionStatement
    {
        public void run()
        {
            //multiplicationTable();
            sumOfNumbers();
        }

        /*1. Write a program that generate the multiplacation table of a number provided by the user using a while or for loop
         *   for eg. if user enter 5 , the program should display the multiplication table from 5*1 to 5*10*/
        private void multiplicationTable()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                int number = Convert.ToInt32(input);

                Console.WriteLine($"\nMultiplication Table of {number}:");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("No input provided.");
            }
        }

        /*2. Sum of Numbers (using for and continue) WAP to ask a positive numeric input from user between 1-10,
         *   perform type Casting into int, Calculate the sum of numbers from 1 to N, excluding 5 (use continue) */
        private void sumOfNumbers()
        {
            Console.Write("Enter a number between 1 and 10: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                int n = (int)Convert.ToDouble(input); // Type casting via double -> int

                if (n >= 1 && n <= 10)
                {
                    int sum = 0;

                    for (int i = 1; i <= n; i++)
                    {
                        if (i == 5)
                        {
                            continue; // Skip 5
                        }
                        sum += i;
                    }

                    Console.WriteLine($"\nSum of numbers from 1 to {n} (excluding 5) = {sum}");
                }
                else
                {
                    Console.WriteLine("Input out of range. Please enter a number between 1 and 10.");
                }
            }
            else
            {
                Console.WriteLine("No input provided.");
            }
        }
    }
}