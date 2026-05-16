using System;

namespace ObjectOriented
{
    internal class InterfaceExample
    {
        public void Run()
        {
            // Cat cat = new Cat { };
            // cat.Eat();
            // cat.HaveMilk();

            CollegeStudent student = new CollegeStudent();
            student.Name = "Dinesh Poudel";
            student.Age = 21;
            student.DisplayInfo();
            student.Study();
        }

        public interface IAnimal
        {
            string Name { get; set; }
            void Eat();

        }

        public interface IMammal
        {

        }

        public class Cat : IMammal, IAnimal
        {
            public string Name { get; set; }
            public void Eat()
            {
                Console.WriteLine("I'm eating");
            }

            public void HaveMilk()
            {
                Console.WriteLine("I'm having milk");
            }
        }


        public interface IStudent
        {
            string Name { get; set; }
            int Age { get; set; }
            void DisplayInfo();
            void Study();
        }

        public class CollegeStudent : IStudent
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }

            public void Study()
            {
                Console.WriteLine($"{Name} is studying");
            }
        }
    }
}