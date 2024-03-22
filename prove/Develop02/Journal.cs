using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;
    public Journal()
   {
        _entries = new List<Entry>();
   } 
   public void AddEntry(Entry newEntry)
   {
        _entries.Add(newEntry);
    }
   public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter sw = File.AppendText(file))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine("Date: " + entry._date);
                sw.WriteLine("Prompt: " + entry._promptText);
                sw.WriteLine("Text: " + entry._entryText);
                sw.WriteLine();
            }
        }
    }
    public void LoadFromFile(string file)
    {

    }
   
}

