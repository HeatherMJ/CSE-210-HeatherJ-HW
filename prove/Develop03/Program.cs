using System;
using System.Linq;
using System.Collections.Generic;
//Create a constructor
public class Program

{
    static void Main(string[] args)
    {
        Scripture john316 = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Console.Clear();
        Scripture.DisplayScripture();
        while (true)
        {
           Console.WriteLine("Hit enter to hide a word or type quit to finish: ");
           string userInput = Console.ReadLine();

           if (userInput.ToLower() == "quit")
           {
            break;
           }
           else
           {               
            Console.Clear();
            scripture.HideWord();
            Scripture.DisplayScripture();
           }

    }
    }
}