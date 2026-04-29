using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnettutorials
{
    internal class ExplicitConversion
    {

        public void run()
        {
            this.ClassTask();
            //this.example();
        }

        private void example()
        {
            double a = 10.5;
            int b = (int)a; //10 (data loss)

            long c = 38823753567;
            byte d = (byte)c;

            Console.WriteLine(d); //(data loss)

            char e = 'A';
            byte f = (byte)e;
            Console.WriteLine(f);
        }

        private void usingConversionClass()
        {
            int g = Convert.ToInt32("134");
            Console.WriteLine(g);
        }

        private void usingParse()
        {

        }

        private void ClassTask()
        {
            /* 1) Ask two number input from user using console.Readline, Type Cast them into numeric value and perform addition, subtraction, multiplication and division. */

             String a = Console.ReadLine();
             String b = Console.ReadLine();

            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);

            Console.WriteLine("Sum = " + (c + d));
            Console.WriteLine("Sub = " + (c - d));
            Console.WriteLine("Mul = " + (c * d));
            Console.WriteLine("Division = " + (c / d));


            /* 2) Ask a floating number input from user using Console.Readline, Type Cast it into double first and then into byte*/

            String num = Console.ReadLine();
            double doubleNum = Convert.ToDouble(num);
            byte byteNum = (byte)doubleNum;

            Console.WriteLine("Double num = " + doubleNum);
            Console.WriteLine("Byte num = " + byteNum);


            /* 3) Ask a single char from user using console.Readline, Type Cast it into char first and then into int*/

            Console.WriteLine("Enter a single character:");
            string input = Console.ReadLine();

            char ch = Convert.ToChar(input);     // Convert string to char
            int asciiValue = (int)ch;            // Explicit conversion from char to int

            Console.WriteLine("Character = " + ch);
            Console.WriteLine("Integer value = " + asciiValue);
        }
    }
}
