using System;
using System.Diagnostics;
using System.IO;
using Develop05;

GoalManager manager = new GoalManager();
bool exit = false;

while (!exit)
{
    Console.WriteLine("Menu Options:");
    Console.WriteLine("1. Create a New Simple Goal");
    Console.WriteLine("2. Create a New Eternal Goal");
    Console.WriteLine("3. Create a New Checklist Goal");
    Console.WriteLine("4. List Goals");
    Console.WriteLine("5. Save Goal");
    Console.WriteLine("6. Load Event");
    Console.WriteLine("7. Record");
    Console.WriteLine("8. Quit");

    Console.WriteLine("Please make a choice:");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter goal name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter goal description:");
            string description = Console.ReadLine();
            Console.WriteLine("Enter points:");
            int points = Convert.ToInt32(Console.ReadLine());
            manager.CreateNewSimpleGoal(name, description, points);
            break;

        case "2":
            Console.WriteLine("Enter goal name:");
            string _shortNamename = Console.ReadLine();
            Console.WriteLine("Enter goal description:");
            string _description = Console.ReadLine();
            Console.WriteLine("Enter points:");
            int _points = Convert.ToInt32(Console.ReadLine());
            manager.CreateNewEternalGoal(_shortNamename, _description, _points);
            break;

        case "3":
            Console.WriteLine("Enter goal name:");
            string _shortName = Console.ReadLine();
            Console.WriteLine("Enter goal description:");
            string _descriptions = Console.ReadLine();
            Console.WriteLine("Enter points:");
            int _point = Convert.ToInt32(Console.ReadLine());
            manager.CreateNewChecklistGoal(_shortName, _descriptions, _point);
            break;

        case "4":
            Console.WriteLine();
            manager.ListGoalDetails();
            break;

        case "5":
            Console.WriteLine();
            manager.SaveGoals();
            break;

        case "6":
            Console.WriteLine();
            manager.LoadGoals();
            break;

        case "7":
            Console.WriteLine();
            manager.RecordEvent();
            break;

        case "8":
            exit = true;
            break;

        default:
            Console.WriteLine("Nope, bad choice, brah!");
            break;
    }
}