using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class LambdaExpression
    {
    }

    class AnonymousDelegate
    {
        public void example()
        {
            Action<string> greet = delegate(string name)
            {
                Console.WriteLine($"Hello, {name}!");
            };
            greet("Alice");
        }

       
    }
    class LamdaExample
    {
        public void example()
        {
            Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
            greet("Bob");
        }

    }


}