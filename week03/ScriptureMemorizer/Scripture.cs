using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _rand = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        // Stretch: Only hide words not already hidden
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                visibleIndexes.Add(i);
        }
        for (int i = 0; i < count && visibleIndexes.Count > 0; i++)
        {
            int idx = _rand.Next(visibleIndexes.Count);
            _words[visibleIndexes[idx]].Hide();
            visibleIndexes.RemoveAt(idx);
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }
}
