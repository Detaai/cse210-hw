using System;
using System.Collections.Generic;

class Program
{
    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        // Creative prompts
        "What made you smile today?",
        "What challenge did you overcome today?"
    };

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Random rand = new Random();
        bool running = true;

        // Creative: Welcome message and tip
        Console.WriteLine("Welcome to your Journal! Tip: Write even a single sentence to build the habit.\n");

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts[rand.Next(prompts.Count)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    journal.AddEntry(new Entry(date, prompt, response));
                    Console.WriteLine("Entry added!\n");
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye! Keep journaling!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }
    }
}
// Creative/Exceeding requirements: Added extra prompts, a welcome tip, and robust file handling. Consider adding tags or moods to entries for further creativity.