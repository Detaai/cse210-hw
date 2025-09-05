using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
            if (grade % 10 < 3)
                sign = "-";
        }
        else if (grade >= 80)
        {
            letter = "B";
            if (grade % 10 >= 7)
                sign = "+";
            else if (grade % 10 < 3)
                sign = "-";
        }
        else if (grade >= 70)
        {
            letter = "C";
            if (grade % 10 >= 7)
                sign = "+";
            else if (grade % 10 < 3)
                sign = "-";
        }
        else if (grade >= 60)
        {
            letter = "D";
            if (grade % 10 >= 7)
                sign = "+";
            else if (grade % 10 < 3)
                sign = "-";
        }
        else
        {
            letter = "F";
        }

        // Handle A+ and F+/- exceptions
        if (letter == "A" && sign == "+")
            sign = "";
        if (letter == "F")
            sign = "";

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
            Console.WriteLine("Congratulations! You passed the course.");
        else
            Console.WriteLine("Don't give up! Try again next time.");
    }
}
