using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number;
        while (!int.TryParse(input, out number))
        {
            Console.Write("That's not a valid number. Try again: ");
            input = Console.ReadLine();
        }
        return number;
    }

    static int SquareNumber(int number)
    {
        // Creative: Add a fun message if the number is 0 or negative
        if (number == 0)
        {
            Console.WriteLine("Zero squared is still zero. Math magic!");
        }
        else if (number < 0)
        {
            Console.WriteLine("Squaring a negative? Bold move!");
        }
        return number * number;
    }

    static void DisplayResult(string name, int squared)
    {
        // Creative: Compliment the user if the squared number is a palindrome
        string squaredStr = squared.ToString();
        string reversed = new string(squaredStr.Reverse().ToArray());
        Console.WriteLine($"{name}, the square of your number is {squared}");
        if (squaredStr == reversed && squaredStr.Length > 1)
        {
            Console.WriteLine("Fun fact: Your squared number is a palindrome!");
        }
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int squared = SquareNumber(favNumber);
        DisplayResult(name, squared);
    }
}
