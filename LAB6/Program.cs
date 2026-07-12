//Using Lambda Expressions with Action, Func, and Predicate

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Action<List<string>> - prints each element of a list
        Action<List<string>> printList = list =>
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        };

        List<string> names = new List<string> { "Ram", "Sita", "Hari" };
        printList(names);

        // 2. Func<int, bool> - checks if a number is even
        Func<int, bool> isEven = num => num % 2 == 0;
        Console.WriteLine("Is 10 even? " + isEven(10));

        // 3. Predicate<int> - checks if a number is multiple of 5
        Predicate<int> isMultipleOf5 = num => num % 5 == 0;
        Console.WriteLine("Is 25 a multiple of 5? " + isMultipleOf5(25));
    }
}