using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class StaticExample
    {
        public void Run()
        {
            //var staticClass = new StaticClass();  Cannot create object of static classes
            //Laptop1 laptop1 = new Laptop1();
            //Laptop1 laptop11 = new Laptop1(10);

            Student student1 = new Student("Dinesh Poudel", 013, 3.4);
            Student student2 = new Student("Pajwal Sharma", 014, 3.7);
            Student student3 = new Student("Kritika Parajuli", 015, 3.3);
            student3.getInfo();
            Student.displaySchoolInfo();
        }
    }
    public static class StaticClass
    {
        public static void test()// all the members must be static inside a static class
        {

        }
    }
    class Laptop1
    {
        public static string manufacturer;
        public int ramSize;

        public Laptop1()
        {
            manufacturer = "Dell";

            Console.WriteLine();
        }


        public Laptop1(int ramSize)
        {
            this.ramSize = ramSize;
            Console.WriteLine(ramSize);
            Console.WriteLine(manufacturer);
        }
        
    }
    class Student
    {
        public static string schoolName;
        public static int totalStudents;
        public string name;
        public int studentId;
        public double gpa;
        static Student()
        {
            schoolName = "Nepathya College";
            totalStudents = 0;
            Console.WriteLine("Welcome To Nepathya School");
            
        }

        public Student(string name,int studentId, double gpa)
        {
            this.name = name;
            this.studentId = studentId;
            this.gpa = gpa;
            totalStudents += 1;
            Console.WriteLine("Student Added :" + name);
        }

        public void getInfo()
        {
            Console.WriteLine("School Name = " + schoolName);
            Console.WriteLine("Total Number Of Students = "+totalStudents);
            Console.WriteLine("Student Name = "+name);
            Console.WriteLine("Student Id = "+ studentId);
            Console.WriteLine("GPA = "+gpa);
        }
        public static void displaySchoolInfo()
        {
            Console.WriteLine(schoolName);
            Console.WriteLine(totalStudents);
        }
    }
}