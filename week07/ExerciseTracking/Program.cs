using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise Tracking Program");
            Console.WriteLine("==========================");
            Console.WriteLine();

            // Create a list to hold different types of activities
            // This demonstrates polymorphism - the list can hold any Activity objects
            List<Activity> activities = new List<Activity>();

            // Create instances of each activity type
            // Running: date, minutes, distance (miles)
            Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
            
            // Cycling: date, minutes, speed (mph)
            Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 6.0);
            
            // Swimming: date, minutes, laps
            Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);

            // Add activities to the list
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            // Iterate through the list and display summaries
            // This demonstrates polymorphism in action - each object's overridden methods are called
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }

            // Additional examples with different dates and values
            Console.WriteLine("Additional Activity Examples:");
            Console.WriteLine("============================");
            Console.WriteLine();

            // Create more diverse examples
            Running running2 = new Running(new DateTime(2022, 11, 5), 45, 5.2);
            Cycling cycling2 = new Cycling(new DateTime(2022, 11, 6), 25, 15.0);
            Swimming swimming2 = new Swimming(new DateTime(2022, 11, 7), 35, 40);

            List<Activity> moreActivities = new List<Activity> { running2, cycling2, swimming2 };

            foreach (Activity activity in moreActivities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }

            Console.WriteLine("Program demonstrates:");
            Console.WriteLine("- Inheritance: All classes inherit from Activity base class");
            Console.WriteLine("- Polymorphism: Each class overrides abstract methods differently");
            Console.WriteLine("- Encapsulation: All member variables are private");
            Console.WriteLine("- Method Overriding: GetDistance, GetSpeed, GetPace methods");
        }
    }
}