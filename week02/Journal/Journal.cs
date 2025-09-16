using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.\n");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine($"Journal saved to {filename}\n");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }
        foreach (string line in File.ReadAllLines(filename))
        {
            Entry entry = Entry.FromFileString(line);
            if (entry != null)
                _entries.Add(entry);
        }
        Console.WriteLine($"Journal loaded from {filename}\n");
    }
}



