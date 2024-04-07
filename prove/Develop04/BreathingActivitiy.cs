using System;
using System.Threading;

namespace Develop04;

public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
        {
            _name = "Breathing Activity";
        _description = "This activity will relax you through the power of breathing your mind will focus and you will let go of all things necessary.";
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("Please Enter the duration in seconds: ");
            int.TryParse(Console.ReadLine(), out duration);
            ShowCountDown(5);
            Console.WriteLine("Lets, begin. Close your eyes.");

            int leftDuration = duration;
            while (leftDuration > 0)
            {
                Console.WriteLine("Breathe in....");
                ShowSpinner(5);
                leftDuration -= 5;

                if (leftDuration > 5)
                {
                    Console.WriteLine("Breathe out....");
                    ShowSpinner(5);
                    leftDuration -= 5;
                }
            }

            DisplayEndingMessage();
        }
    }
