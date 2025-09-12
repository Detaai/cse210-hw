using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}\n");
    }

    // For saving to file
    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    // For loading from file
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
            return new Entry(parts[0], parts[1], parts[2]);
        return null;
    }
}
