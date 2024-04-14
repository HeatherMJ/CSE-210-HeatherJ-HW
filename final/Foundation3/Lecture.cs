using System;

namespace OutdoorEvent
{
    public class Lecture : Event // Assuming Event is the base class
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
        }
    }
}