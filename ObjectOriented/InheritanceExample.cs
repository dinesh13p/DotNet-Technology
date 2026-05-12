using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class InheritanceExample
    {
        public void run()
        {
            ElectricCar car = new ElectricCar("BYD");
            var a = car.name;
            car.Start();

            Truck truck = new Truck("Tata");
            truck.LoadTruck();
        }
    }

    class Vehicle
    {
        public string name;

        public Vehicle(string name)
        {
            this.name = name;
        }
        public void Start()
        {
            Console.WriteLine("Vehicle Started");
        }
    }
    class ElectricCar : Vehicle
    {
        public ElectricCar(string name):base(name)
        {
            
        }
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
        public void Charge()
        {
            Console.WriteLine("Charging");
        }
    }
    class PetrolCar : Vehicle {

        public PetrolCar(string name) : base(name)
        {
        }

        public void Drive()
        {
            Console.WriteLine("Driving");
        }
        public void FillPetrol()
        {
            Console.WriteLine("Filling petrol");
        }
    }

    class Bike : Vehicle { 

        public Bike(string name) : base(name) { }
        public void Ride()
        {
            Console.WriteLine("Riding");
        }
    }

    class Truck : Vehicle { 

        public Truck(string name) : base(name)
        {
        }

        public void LoadTruck()
        {
            Console.WriteLine("Loading Truck");
        }
    }
}