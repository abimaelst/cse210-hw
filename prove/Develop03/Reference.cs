using System;

public class Reference
{
    string _book;
    int _chapter;
    int _verse;
    int? _endVerse = null;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public int? GetEndVerse()
    {
        return _endVerse;
    }

    public string getDisplayText()
    {
        if (_endVerse != null)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        return $"{_book} {_chapter}:{_verse}";
    }
}

