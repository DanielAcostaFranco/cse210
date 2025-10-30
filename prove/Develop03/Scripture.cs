using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string scripText)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = scripText.Split(' ');
        foreach (string p in parts)
        {
            _words.Add(new Word(p));
        }
    }

    public string Display()
    {
        string line = "";
        foreach (Word w in _words)
        {
            line += w.ReplaceWord() + " ";
        }
        return _reference.Display() + " " + line.TrimEnd();
    }

    public bool AllHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }

    public void HideRandomWords()
    {
        int count = 3;

        List<int> available = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                available.Add(i);
        }

        if (available.Count == 0)
            return;

        if (count > available.Count)
            count = available.Count;

        for (int i = 0; i < count; i++)
        {
            int pick = _random.Next(available.Count);
            _words[available[pick]].Hide();
            available.RemoveAt(pick);
        }
    }

}