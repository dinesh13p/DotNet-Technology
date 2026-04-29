// using System;
// using System.Runtime.CompilerServices;

// namespace dotnettutorials
// {
//     struct User
//     {
//         public string firstName;
//         public string lastName;

//         public string GetFullName()
//         {
//             return firstName + " " + lastName;
//         }
//     }
//     struct Point1
//     {
//         public int X;
//         public char lable;
//     }
//     struct Point2
//     {
//         public int X;
//         public string Name;
//     }
//     struct Point3
//     {
//         public int X;
//         public NameInfo Name;
//     }
//     class NameInfo
//     {
//         public string Name;
//     }
//     internal class StructExample
//     {
//         public void Run()
//         {
//             // point1Example();
//         }

//         private void Example()
//         {
//             User user1;
//             User user2 = new User();

//             user2.firstName = "Kishir";
//             user2.lastName = "Sharma";

//             var fullname = user2.GetFullName();
//             Console.WriteLine(fullname);
//         }
//         private void point1Example()
//         {
//             Point1 p1 = new Point1();
//             p1.X = 10;
//             p1.lable = 'A';

//             Point1 p2 = p1;
//             Console.WriteLine($"P1 X = {p1.X} Label = {p1.lable}");
//             Console.WriteLine($"P2 X = {p2.X} Label = {p2.lable}");

//         }
//         private void point2Example()
//         {
//             Point2 p1 = new Point2();

//             p1.X = 20;
//             p1.Name = "Prajwal";

//             Point2 p2 = p1;
//             p2.Name = "Kishor";
//             Console.WriteLine($"P1 X = {p1.X} Name = {p1.Name}");
//             Console.WriteLine($"P2 X = {p2.X} Name = {p2.Name}");



//         }
//     }
// }