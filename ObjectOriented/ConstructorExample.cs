using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class ConstructorExample
    {
        public void run()
        {
            // Laptop laptop = new Laptop();
            // var s = Laptop.manufacturer;
            // Console.WriteLine(s);
            // //Console.WriteLine(laptop.ramSize);

            // Laptop laptop1 = new Laptop(laptop);
            // Console.WriteLine(laptop1.ramSize);

            // Laptop laptop2 = new Laptop(16, "Air M4", 54321);
            // Laptop laptop3 = new Laptop(laptop2);

            // Console.WriteLine(laptop3.ramSize);



            // Singleton s1 = Singleton.getInstance();
            // Singleton s2 = Singleton.getInstance();

            // s1.name = "Dinesh Poudel";         
            // Console.WriteLine(s1.name);         // "Dinesh Poudel"
            // Console.WriteLine(s2.name);         // same — s1 and s2 are the same object
            // Console.WriteLine(Object.ReferenceEquals(s1, s2)); // True


            Laptop laptop4 = new Laptop(16, "Acer", "EXTENSA 15", 67890);
            laptop4 = null;
            GC.Collect(); // Force garbage collection to see the destructor in action
            GC.WaitForPendingFinalizers();// Wait for the finalizer to complete
        }

        class Laptop
        {
            public static string manufacturer;
            public int ramSize;
            public string modelName;
            public readonly int serialNumber;

            static Laptop()
            {
                Console.WriteLine("Static constructor called");
                manufacturer = "MacBook";
            }
            public Laptop()
            {
                Console.WriteLine("Instance constructor called");
                ramSize = 16;
                modelName = "Air M4";
                serialNumber = 12345;
            }
            public Laptop(int ramSize, string modelName, string modelNumber, int serialNumber)
            {
                this.ramSize = ramSize;
                this.modelName = modelName;
                this.serialNumber = serialNumber;
            }
            public Laptop(Laptop existingLaptop)
            {
                ramSize = existingLaptop.ramSize;
                modelName = existingLaptop.modelName;
                serialNumber = existingLaptop.serialNumber;
            }
        }

        class Singleton
        {
            public string name;
            private static Singleton instance;

            private Singleton(string name)
            {
                this.name = name;
            }

            public static Singleton getInstance()
            {
                if (instance == null)
                    instance = new Singleton("Singleton Instance");
                return instance;
            }
        }
    }
}