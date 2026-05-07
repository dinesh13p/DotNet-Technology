using System;
using OOP;

namespace ObjectOriented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using Constructor 1
            // Student s1 = new Student("Samman", "A");
            // Console.WriteLine("Student 1:");
            // s1.DisplayInfo();

            // Console.WriteLine();

            // Using Constructor 2
            // Student s2 = new Student("Rameyy");
            // Console.WriteLine("Student 2:");
            // s2.DisplayInfo();


            // var IndexerExample = new IndexerExample();
            // IndexerExample.run();

            var staticExample = new StaticExample();
            staticExample.Run();
        }
    }
}