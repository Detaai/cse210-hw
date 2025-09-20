using System;

class Program
{
    static void Main(string[] args)
    {
    // Example scripture: Alma 37:6
    Reference reference = new Reference("Alma", 37, 6);
    string text = "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.";
        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        scripture.Display();
        while (true)
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine() ?? "";
            if (input != null && input.ToLower() == "quit")
                break;
            scripture.HideRandomWords(3); // Hide 3 words at a time
            Console.Clear();
            scripture.Display();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden! Now, type the scripture from memory:");
                string userScripture = Console.ReadLine() ?? "";
                Console.WriteLine("\nYour version:");
                Console.WriteLine(userScripture);
                Console.WriteLine("\nOriginal:");
                Console.WriteLine(text);
                Console.WriteLine("\nGreat effort! Compare your version to the original above.");
                break;
            }
        }
    }
}
// Creative: Only hides words not already hidden. You can easily add a scripture library or file loading for extra credit.
