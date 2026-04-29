using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnettutorials
{
    internal class ReferenceTypeExample
    {
        public void run() {
            objectExample();
        }
        private void objectExample() {
            object x = "Hello";
          
            Console.WriteLine(((string)x).Length);
        }

        private void dynamicExample()
        {
            dynamic x = "Baniya";
            Console.WriteLine(x.Length);
            x = 10;
            Console.WriteLine(x+20);
            x = 'A';
        }
    }
}
