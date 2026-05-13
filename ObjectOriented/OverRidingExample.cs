using System;

namespace ObjectOriented
{
    
    internal class OverRidingExample
    {
        
        public void Run()
        {
            Vehicles car = new ElectricCars();
            car.Start();
        }
    }

    class Vehicles
    {
        public string name;
        public virtual void Start()
        {
            Console.WriteLine("Vehicle Started");
        }
    }

    class ElectricCars : Vehicles
    {
        //overriding --> override
        //method hiding --> new
        public override void Start()
        {
            Console.WriteLine("Electric Vehicle Started");
        }

        public void Drive()
        {
        }
        public void Charge()
        {
        }
    }
}