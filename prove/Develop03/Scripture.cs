using System;
using System.Dynamic;
using System.Collections.Generic;
public class Scripture
{
    // This is how to hide a specified number of random words in the scripture
    public void HideRandomWord(int numberToHide);
    {

    }
    // How to get the display of word of the scripture, with some of the words hidden
    public string GetDisplayText();
    {

    }
    //How to check if the scripture is totally hiddden 
    public bool IsCompletelyHidden();
    {

    }

    public string _reference {get; set;}

    public List<Word> _words {get; set;}
}