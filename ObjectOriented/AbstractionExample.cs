using System;
using System.Collections.Generic;

namespace ObjectOriented
{
    internal class AbstractionExample
    {
        public void Run()
        {
            // Animal dog = new Dog();
            // dog.MakeSound();

            // Console.WriteLine();


            StudentBase student = new CollegeStudent
            {
                Name = "Dinesh Poudel",
                Age = 21
            };

            student[0] = "C# Basics";
            student[1] = "Object Oriented Programming";

            student.DisplayInfo();
        }
    }

    public abstract class Animal
    {
        public abstract void MakeSound();
        public void Eat() => Console.WriteLine("Animal Eating");
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks....");
        }
    }


    public abstract class StudentBase
    {
        private readonly List<string> courses = new List<string>();

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= courses.Count)
                {
                    throw new IndexOutOfRangeException("Invalid course index.");
                }

                return courses[index];
            }
            set
            {
                if (index < 0)
                {
                    throw new IndexOutOfRangeException("Invalid course index.");
                }

                if (index == courses.Count)
                {
                    courses.Add(value);
                    return;
                }

                if (index < courses.Count)
                {
                    courses[index] = value;
                    return;
                }

                throw new IndexOutOfRangeException("Invalid course index.");
            }
        }

        public abstract void DisplayInfo();
    }

    public class CollegeStudent : StudentBase
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Course 1: {this[0]}");
            Console.WriteLine($"Course 2: {this[1]}");
        }
    }

}