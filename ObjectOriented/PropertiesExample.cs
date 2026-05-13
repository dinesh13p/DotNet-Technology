using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class PropertiesExample
    {
        public void run()
        {
            Person person = new Person();
            var a = person.Name;
            person.Name = "Dinesh Poudel";
            Console.WriteLine(a);
            Console.WriteLine(person.Name);
        }
    }

    public class Person {
        private String name = string.Empty;
        public String Name
        {
            get { return name; } 
            set { name = value; }
            }

        }
    
}