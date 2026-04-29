using System;

namespace dotnettutorials
{
    internal class StatementExample
    {
        public void run()
        {
            //example();
            //arithmeticOperation();
            //dayOfWeekProgram();
            iterationExample();
        }

        private void example()
        {
            double a = 10.5;
            int b = (int)a;
            Console.WriteLine(b);

            long c = 345246535475;
            byte d = (byte)c;
            Console.WriteLine(d);

            char e = 'A';
            byte f = (byte)e;
            Console.WriteLine(f);

            int g = Convert.ToInt32("123");
            Console.WriteLine(g);
        }

        private void arithmeticOperation()
        {
            Console.Write("Enter a floating number: ");
            string e = Console.ReadLine();

            if (!string.IsNullOrEmpty(e))
            {
                double f = Convert.ToDouble(e);
                Console.WriteLine("Double value: " + f);

                byte g = Convert.ToByte(f);
                Console.WriteLine("Byte value: " + g);
            }
            else
            {
                Console.WriteLine("No input provided.");
            }
        }

        private void dayOfWeekProgram()
        {
            Console.Write("Enter a number (1-7): ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                int day = Convert.ToInt32(input);

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please enter between 1-7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No input provided.");
            }
        }

        private void iterationExample()
        {
            // for loop
            Console.WriteLine("-- for loop --");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Iteration: {i}");
            }

            // foreach loop
            Console.WriteLine("\n-- foreach loop --");
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string day in days)
            {
                Console.WriteLine($"Day: {day}");
            }

            // while loop
            Console.WriteLine("\n-- while loop --");
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine($"While count: {count}");
                count++;
            }

            // do-while loop
            Console.WriteLine("\n-- do-while loop --");
            int num = 0;
            do
            {
                Console.WriteLine($"Do-While num: {num}");
                num++;
            } while (num < 5);

            // break and continue
            Console.WriteLine("\n-- break & continue --");
            for (int i = 0; i < 10; i++)
            {
                if (i == 3) continue; // skip 3
                if (i == 7) break;    // stop at 7
                Console.WriteLine($"Value: {i}");
            }
        }
    }
}