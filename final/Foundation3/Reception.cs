using System;

namespace OutdoorEvent
{
    public class Reception : Event
    {
        private string _rsvp;

        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvp)
            : base(title, description, date, time, address)
        {
            _rsvp = rsvp;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nRSVP: {_rsvp}";
        }
    }
}