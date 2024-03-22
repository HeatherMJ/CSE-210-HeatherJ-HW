using System;
using System.IO;
//This is a code template for the category of things associated with Entry
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
     // Constructor to initialize the entry's date, prompt text, and entry text
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    // Display method to print entry details to the console
    public void Display()
    {
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Text: " + _entryText);
    }
}