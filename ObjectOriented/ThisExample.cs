using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class ThisExample
    {

        public void run()
        {
            var person1 = new Person1();
            person1.SetName("Default User");
            person1.setPerson();
            Console.WriteLine(User.name);
            User user = new User();
            Console.WriteLine(User.name);

        }
    }
        class User
        {
            public static string name = string.Empty;

            public static void setPerson(Person1 person1)
            {
                if (person1 != null)
                    name = person1.Name;
            }
        }

        class Person1
        {
            private string name = string.Empty;
            public void SetName(string name)
            {
                this.name = name;
            }

            public string Name { get { return name; } }

            public void setPerson()
            {
                User.setPerson(this);
            }
        }
    }