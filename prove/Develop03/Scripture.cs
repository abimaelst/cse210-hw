using System;
using System.Collections.Generic;
public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        foreach (Word word in _words.FindAll(word => !word.isHidden()).OrderBy(w => random.Next()).Take(numberToHide))
        {
            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.isHidden());
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += $"{word.getDisplayText()} ";
        }


        return $"{_reference.getDisplayText()} - {text}";
    }

    public bool IsComplatedHide()
    {
        return false;
    }
}