//using System;

//namespace dotnettutorials
//{
//    // Define an enum outside the class
//    enum Direction
//    {
//        North,
//        South,
//        East,
//        West
//    }

//    enum Season
//    {
//        Spring = 1,
//        Summer = 2,
//        Autumn = 3,
//        Winter = 4
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Basic enum usage
//            Direction myDirection = Direction.North;
//            Console.WriteLine(myDirection);        // Output: North
//            Console.WriteLine((int)myDirection);   // Output: 0  (default starts at 0)

//            // Enum with custom values
//            Season currentSeason = Season.Summer;
//            Console.WriteLine(currentSeason);        // Output: Summer
//            Console.WriteLine((int)currentSeason);   // Output: 2

//            // Using enum in if statement
//            if (myDirection == Direction.North)
//            {
//                Console.WriteLine("We are heading North!");
//            }

//            // Using enum in switch statement
//            switch (currentSeason)
//            {
//                case Season.Spring:
//                    Console.WriteLine("It's Spring!");
//                    break;
//                case Season.Summer:
//                    Console.WriteLine("It's Summer!");
//                    break;
//                case Season.Autumn:
//                    Console.WriteLine("It's Autumn!");
//                    break;
//                case Season.Winter:
//                    Console.WriteLine("It's Winter!");
//                    break;
//            }
//        }
//    }
//}