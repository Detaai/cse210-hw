using System;

namespace ExerciseTracking
{
    // Base Activity class - demonstrates inheritance and polymorphism
    public abstract class Activity
    {
        // Private member variables following encapsulation principles
        private DateTime _date;
        private int _minutes;

        // Constructor to initialize shared attributes
        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        // Protected properties to allow derived classes access while maintaining encapsulation
        protected DateTime Date => _date;
        protected int Minutes => _minutes;

        // Abstract methods that must be implemented by derived classes
        // This demonstrates polymorphism - each derived class will provide its own implementation
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // Virtual method that can be overridden if needed, but provides a default implementation
        public virtual string GetSummary()
        {
            // This method uses the overridden methods from derived classes
            // Demonstrates how polymorphism allows the base class to use derived implementations
            return $"{_date:dd MMM yyyy} {GetActivityType()} ({_minutes} min) - " +
                   $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, " +
                   $"Pace: {GetPace():F1} min per mile";
        }

        // Abstract method to get the activity type name
        protected abstract string GetActivityType();
    }
}