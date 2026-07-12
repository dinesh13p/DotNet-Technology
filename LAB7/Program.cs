//LINQ Operations on Employee Data

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }
    public bool IsResigned { get; set; }
    public int Experience { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Ram", Salary = 50000, Department = "IT", IsResigned = false, Experience = 3 },
            new Employee { Name = "Sita", Salary = 70000, Department = "HR", IsResigned = false, Experience = 0 },
            new Employee { Name = "Hari", Salary = 60000, Department = "IT", IsResigned = true, Experience = 5 },
            new Employee { Name = "Gita", Salary = 45000, Department = "Finance", IsResigned = false, Experience = 2 },
            new Employee { Name = "Shyam", Salary = 80000, Department = "HR", IsResigned = false, Experience = 4 }
        };

        // 1. Employees who are currently working
        var workingEmployees = employees.Where(e => !e.IsResigned).ToList();
        Console.WriteLine("Currently Working Employees:");
        foreach (var e in workingEmployees)
            Console.WriteLine(e.Name);

        // 2. Sort employees by Salary in descending order
        var sortedBySalary = employees.OrderByDescending(e => e.Salary).ToList();
        Console.WriteLine("\nEmployees Sorted by Salary (Descending):");
        foreach (var e in sortedBySalary)
            Console.WriteLine($"{e.Name} - {e.Salary}");

        // 3. Distinct Department values
        var distinctDepartments = employees.Select(e => e.Department).Distinct().ToList();
        Console.WriteLine("\nDistinct Departments:");
        foreach (var dept in distinctDepartments)
            Console.WriteLine(dept);

        // 4. Check if any employee has zero years of experience
        bool hasZeroExperience = employees.Any(e => e.Experience == 0);
        Console.WriteLine("\nAny employee with zero experience? " + hasZeroExperience);

        // 5. New list containing only Name and Salary
        var nameSalaryList = employees.Select(e => new { e.Name, e.Salary }).ToList();
        Console.WriteLine("\nName and Salary List:");
        foreach (var e in nameSalaryList)
            Console.WriteLine($"{e.Name} - {e.Salary}");
    }
}