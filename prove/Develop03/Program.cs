using System;
using System.Diagnostics;


class Program
{
    static void Main(string[] args)
    {
            // Scripture is the type of the variable that is declared, john316 is the name of the variable
        Scripture john316 = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.WriteLine("Welcome to the Scripture Memorizer Program!!");
        Console.WriteLine("Please press ENTER to continue. ");

        Console.WriteLine("Want to quit? Type 'quit' to exit now! ");

        bool allWordsHidden = false;
        while (!allWordsHidden)
        {
                // This will make sure that if the user types in lower or uppercase quit it is recognized
            if (Console.ReadLine().ToLower() == "quit")
                break;

            Console.Clear();
            john316.Display();
            john316.HideRandomWord();
            allWordsHidden = john316.AllWordsHidden();
        }
    }
}
