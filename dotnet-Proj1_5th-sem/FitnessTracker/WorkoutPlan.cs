// using System;
// using FitnessTracker.Workout;  // add this


// namespace FitnessTracker.Workout
// {
//     public class WorkoutPlan
//     {
//         public void Run()
//         {
//             Console.WriteLine("Lift the Dubmles. Stay Healthy.");
//         }
//     }
// }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetStruct.FitnessTracker
{
    internal class WorkOutPlan
    {

        public string exercise;
        public string LogWorkout()
        {
            return "Exercise Logged: " + exercise;
        }

    }
}