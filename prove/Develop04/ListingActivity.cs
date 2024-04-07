using System;
using System.Threading;

namespace Develop04;

public class ListingActivity : Activity
    {
        private string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        public ListingActivity(string name, string description, int duration) : base(name, description, duration)
        {
            _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("Please Enter the duration in seconds: ");
            int.TryParse(Console.ReadLine(), out duration);
            ShowCountDown(5);
            Console.WriteLine("Lets, begin. Close your eyes.");

            //Create random prompt
           Random random = new Random();
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine($"Prompt: {prompt}");

            ShowCountDown(5);
            Console.WriteLine("List as many items as you can, ready set, go! ");
            int itemsCount = 0;
            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                    itemsCount++;
            }
            Console.WriteLine($"Here are the numbers of items you entered: {itemsCount}");
                   
            DisplayEndingMessage();
        }
    }
