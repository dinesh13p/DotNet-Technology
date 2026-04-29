using System;
using System.Collections.Generic;

namespace dotnettutorials
{
    internal class ArrayExamples
    {
        public void Run()
        {
            // this.task1();
            // this.task2();
            // this.task3();
            this.task4();
        }

        private void task1()
        {
            int[] data = new int[10];

            for (int i = 0; i < data.Length; i++)
                data[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < data.Length; i++)
                Console.Write(data[i] + " ");
        }

        private void task2()
        {
            List<string> hobbies = new List<string>();

            Console.WriteLine("Enter 5 hobbies:");

            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine() ?? "";
                hobbies.Add(input);
            }

            Console.Write("Do you want to add more hobbies? (yes/no): ");
            string choice = (Console.ReadLine() ?? "").ToLower();

            if (choice == "yes")
            {
                Console.Write("How many more hobbies?: ");
                int extra = Convert.ToInt32(Console.ReadLine() ?? "0");

                for (int i = 0; i < extra; i++)
                {
                    Console.Write("Enter hobby: ");
                    string input = Console.ReadLine() ?? "";
                    hobbies.Add(input);
                }
            }

            Console.WriteLine("Your hobbies are:");
            foreach (var hobby in hobbies)
            {
                Console.WriteLine(hobby);
            }
        }

        private void task3()
        {
            int[,] table = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Multiplication Table of {i + 1}:");

                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i + 1} x {j + 1} = {table[i, j]}");
                }

                Console.WriteLine();
            }
        }

        public void task4(){
            int [][] data = new int[5][];

            data[0] = new int [3];
            data[1] = new int [4];
            data[2] = new int [2];
            data[3] = new int [5];
            data[4] = new int [1];

            for (int i = 0; i < data.Length; i++){
                Console.WriteLine($"enter marks for student {i + 1}:");
                for (int j = 0; j < data[i].Length; j++)
                {
                    var inputData = Console.ReadLine();
                    int num = Convert.ToInt32(inputData);
                    data[i][j] = num;
                }
            }

            for (int i = 0; i < data.Length; i++){
                Console.WriteLine($"Marks for students: {i + 1}");
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.Write(data[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}