using System;

namespace ExerciseTracking
{
    // Running class - inherits from Activity
    public class Running : Activity
    {
        // Private member variable specific to running
        private double _distance; // in miles

        // Constructor that calls base constructor and sets running-specific data
        public Running(DateTime date, int minutes, double distance) 
            : base(date, minutes)
        {
            _distance = distance;
        }

        // Override abstract methods from base class
        public override double GetDistance()
        {
            // For running, distance is directly stored
            return _distance;
        }

        public override double GetSpeed()
        {
            // Speed = distance / time * 60 (to convert from minutes to hours)
            return (_distance / Minutes) * 60;
        }

        public override double GetPace()
        {
            // Pace = time / distance (minutes per mile)
            return Minutes / _distance;
        }

        // Override the protected method to return activity type
        protected override string GetActivityType()
        {
            return "Running";
        }
    }
}