using System;


/*
    Class task:
    Create a Student class with:
    Name and Grade properties.
    Constructor1 = that takes only name and grade
    Constructor2 = that takes only name [ sets grade to "Not assigned" using constructor chaining.]
    A method to display student information.
*/


namespace ObjectOriented
{
    public class Student
    {
        // Properties
        public string Name { get; set; }
        public string Grade { get; set; }

        // Constructor 1 (name + grade)
        public Student(string name, string grade)
        {
            Name = name;
            Grade = grade;
        }

        // Constructor 2 (only name) using constructor chaining
        public Student(string name) : this(name, "Not Assigned")
        {
        }

        // Method to display info
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Grade: {Grade}");
        }
    }
}