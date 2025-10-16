using System;

namespace ExerciseTracking
{
    // Cycling class - inherits from Activity
    public class Cycling : Activity
    {
        // Private member variable specific to cycling
        private double _speed; // in miles per hour

        // Constructor that calls base constructor and sets cycling-specific data
        public Cycling(DateTime date, int minutes, double speed) 
            : base(date, minutes)
        {
            _speed = speed;
        }

        // Override abstract methods from base class
        public override double GetDistance()
        {
            // Distance = speed * time (converting minutes to hours)
            return _speed * (Minutes / 60.0);
        }

        public override double GetSpeed()
        {
            // For cycling, speed is directly stored
            return _speed;
        }

        public override double GetPace()
        {
            // Pace = 60 / speed (minutes per mile)
            return 60.0 / _speed;
        }

        // Override the protected method to return activity type
        protected override string GetActivityType()
        {
            return "Cycling";
        }
    }
}