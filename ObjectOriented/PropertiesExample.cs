using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented
{
    internal class PropertiesExample
    {

        public void run()
        {
            Person person=new Person();
            var a = person.Name;
            person.Name = "Dinesh Poudel";
            Console.WriteLine(a);
            Console.WriteLine(person.Name);
        }
    }

    public class Person {
    private string name = string.Empty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

}