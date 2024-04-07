using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflecting Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");

                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "Description", 5);
                        breathingActivity.Run();
                        break;
                    case "2":
                        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "Description", 5);
                        reflectingActivity.Run();
                        break;
                    case "3":
                        ListingActivity listingActivity = new ListingActivity("Listing Activity", "Description", 5);
                        listingActivity.Run();
                        break;
                    case "4":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }

            TimeSpan totalTimeSpent = DateTime.Now - startTime;
            Console.WriteLine($"You have spent {totalTimeSpent.TotalMinutes:N0} minute(s) and {totalTimeSpent.Seconds} seconds in total Mindfulness this session.");
            Console.WriteLine("Namaste");
        }
    }
}