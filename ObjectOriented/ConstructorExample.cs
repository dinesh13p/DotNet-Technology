using System;

namespace ObjectOriented
{
    internal class ConstructorExample
    {
        public void Run()
        {
            // Default constructor
            var l1 = new Laptop();
            Console.WriteLine("Default Constructor:");
            l1.Display();

            // Parameterized constructor
            var l2 = new Laptop(16, "Dell XPS", 101);
            Console.WriteLine("\nParameterized Constructor:");
            l2.Display();

            // Copy constructor
            var l3 = new Laptop(l2);
            Console.WriteLine("\nCopy Constructor:");
            l3.Display();

            // Static field
            Console.WriteLine($"\nManufacturer: {Laptop.Manufacturer}");

            // Singleton usage
            Console.WriteLine("\nSingleton Example:");
            var s1 = Singleton.Instance;
            var s2 = Singleton.Instance;

            Console.WriteLine(
                s1 == s2
                ? "Both instances are the SAME (Singleton works)"
                : "Different instances (Error)"
            );
        }
    }

    internal class Laptop
    {
        // Static property
        public static string Manufacturer { get; }

        // Properties (cleaner than public fields)
        public int RamSize { get; }
        public string ModelName { get; }
        public int SerialNumber { get; }

        // Static constructor
        static Laptop()
        {
            Manufacturer = "Dell";
        }

        // Default constructor
        public Laptop()
        {
            RamSize = 0;
            ModelName = "Unknown";
            SerialNumber = 0;
        }

        // Parameterized constructor
        public Laptop(int ramSize, string modelName, int serialNumber)
        {
            RamSize = ramSize;
            ModelName = modelName;
            SerialNumber = serialNumber;
        }

        // Copy constructor
        public Laptop(Laptop existing)
        {
            RamSize = existing.RamSize;
            ModelName = existing.ModelName;
            SerialNumber = existing.SerialNumber;
        }

        // Destructor
        ~Laptop()
        {
            Console.WriteLine($"Destructor called for: {ModelName}");
        }

        public void Display()
        {
            Console.WriteLine($"Model: {ModelName}, RAM: {RamSize}GB, Serial: {SerialNumber}");
        }
    }

    // Singleton (thread-safe)
    internal sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        // Private constructor
        private Singleton() { }

        public static Singleton Instance => instance;
    }
}
