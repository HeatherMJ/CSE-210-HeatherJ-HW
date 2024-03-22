using System;
using System.IO;
using System.Collections.Generic;

class Program

{
    static void Main(string[] args)
    {
       
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            
            Console.WriteLine("Hey, Hey, Hey! What's in your heart today? ");
            Console.WriteLine("Select 1 choice! :");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load it up! ");
            Console.WriteLine("5. Quit");
            Console.WriteLine();


            
            Console.WriteLine("Select your choice! ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the date (yyyy-MM-dd):");
                    string date = Console.ReadLine();
                    Console.WriteLine("Enter the prompt:");
                    string prompt = Console.ReadLine();
                    Console.WriteLine("Enter your thoughts:");
                    string text = Console.ReadLine();
                    journal.AddEntry(new Entry(date, prompt, text));
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine ("What is the name for your file to save?");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine ("File saved!");
                    break;
                case 4:
                    Console.WriteLine ("What is the name for your file to load?");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine ("File Restored!");
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Nope! Wrong! Please try again brah :)");
                    break;
            }

            Console.WriteLine();

        }

    }


}