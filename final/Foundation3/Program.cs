using System;

namespace OutdoorEvent
{
    public class Program
    {
        static void Main(string[] args)
        {
            Address eventAddress = new Address("2445 East Bakersfield Rd.", "Enosburg Falls", "Vermont", "05452");
            Event[] events = new Event[]
            {
                new Lecture("Personal Development", "How to Win Friends and Influence People", new DateTime(2024, 4, 30), new TimeSpan(9, 30, 0), eventAddress, "Dale Carnegie", 200),
                new Reception("Baby Shower", "Faith Wootton Baby Shower", new DateTime(2024, 6, 5), new TimeSpan(10, 0, 0), eventAddress, "Chelsea Wootton"),
                new OutdoorGatherings("Ball Game", "Vermont vs. New York", new DateTime(2024, 7, 1), new TimeSpan(11, 0, 0), eventAddress, "Champ")
            };

            foreach (Event evt in events)
            {
                Console.WriteLine($"Event Type: {evt.GetType().Name}");

                Console.WriteLine("------ Standard Details ------");
                Console.WriteLine(evt.GetStandardDetails());

                Console.WriteLine("\n------ Full Details ------");
                Console.WriteLine(evt.GetFullDetails());

                Console.WriteLine("\n------ Short Description ------");
                Console.WriteLine(evt.GetShortDetails());

                Console.WriteLine("\n------------------------------\n");
            }
        }
    }
}