
using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
         _isHidden = false;
    }

     public void DisplayWord()
    {
        if (_isHidden)
            Console.Write("___ ");
        else
            Console.Write(_text + " ");
    }

    public void HideWord()
    {
         _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}