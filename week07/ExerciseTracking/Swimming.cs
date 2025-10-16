using System;

namespace ExerciseTracking
{
    // Swimming class - inherits from Activity
    public class Swimming : Activity
    {
        // Private member variable specific to swimming
        private int _laps; // number of laps completed

        // Constructor that calls base constructor and sets swimming-specific data
        public Swimming(DateTime date, int minutes, int laps) 
            : base(date, minutes)
        {
            _laps = laps;
        }

        // Override abstract methods from base class
        public override double GetDistance()
        {
            // Distance calculation for swimming:
            // Each lap is 50 meters
            // Distance (miles) = laps * 50 / 1000 * 0.62 (convert meters to km to miles)
            return _laps * 50 / 1000.0 * 0.62;
        }

        public override double GetSpeed()
        {
            // Speed = distance / time * 60 (to convert from minutes to hours)
            return (GetDistance() / Minutes) * 60;
        }

        public override double GetPace()
        {
            // Pace = time / distance (minutes per mile)
            return Minutes / GetDistance();
        }

        // Override the protected method to return activity type
        protected override string GetActivityType()
        {
            return "Swimming";
        }
    }
}