using System;

/*
CSE 210 - Mindfulness Program
This program demonstrates inheritance by implementing three different mindfulness activities
that all inherit from a base Activity class.

CREATIVITY AND EXCEEDING CORE REQUIREMENTS:

1. ENHANCED ANIMATIONS:
   - Implemented a sophisticated spinner animation using backspace characters (\b \b)
   - Created smooth countdown timers for breathing exercises
   - Used DateTime-based timing for precise duration control

2. IMPROVED USER EXPERIENCE:
   - Added Console.Clear() functionality to provide clean, focused interface
   - Enhanced visual formatting with proper spacing and separators
   - Implemented smooth transitions between different program phases

3. ADVANCED INHERITANCE DESIGN:
   - Used protected member variables for proper inheritance access
   - Implemented abstract base class with concrete shared functionality
   - Demonstrated polymorphism through base class references

4. ENHANCED FUNCTIONALITY:
   - Added comprehensive prompt lists for varied user experiences
   - Implemented robust random selection algorithms
   - Created reusable timing and animation methods in base class

5. CODE ORGANIZATION:
   - Each class properly separated into individual files
   - Consistent naming conventions throughout (TitleCase for classes/methods, 
     _underscoreCamelCase for member variables, camelCase for local variables)
   - Proper encapsulation with all member variables private/protected

6. BREATHING ACTIVITY ENHANCEMENTS:
   - Different timing for inhale (4 seconds) vs exhale (6 seconds) for realistic breathing
   - Continuous loop until exact duration is reached
   - Visual feedback during each breath cycle

7. REFLECTION ACTIVITY ENHANCEMENTS:
   - Extensive list of meaningful reflection prompts and questions
   - 15-second contemplation periods with spinner animation
   - Smooth progression through multiple questions during session

8. LISTING ACTIVITY ENHANCEMENTS:
   - Real-time item counting during user input
   - Comprehensive prompt variety for different reflection areas
   - Final count display to show user accomplishment
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}