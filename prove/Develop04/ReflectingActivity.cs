using System;
using System.Threading;

namespace Develop04
{

public class ReflectingActivity : Activity
    {
        private string[] prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        private string[] reflectionQuestions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
        {
            _name = "Reflecting Activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
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
            //Console.WriteLine($"Here are the numbers of items you entered: {itemsCount}");
            Console.WriteLine("Breathe in and out slowly as you think on your experiences;");
            foreach (string question in reflectionQuestions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
            Console.Clear();
        }    
    
            DisplayEndingMessage();
        }
    }
}    
