using System;

public class Word
{
    string _text;
    bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }


    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }


    public bool isHidden()
    {
        return getIsHidden();
    }

    bool getIsHidden()
    {
        return _isHidden;
    }

    public string getDisplayText()
    {
        if (isHidden())
        {
            string resultString = new string('_', _text.Length);

            return resultString;
        }

        return _text;
    }
}