using System;

namespace OutdoorEvent
{
    public class Event
    {
        private string _title; 
        private string _description;
        private DateTime _date;
        private TimeSpan _time;
        private Address _address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        public string Title { get { return _title; } }
        public string Description { get { return _description; } }
        public DateTime Date { get { return _date; } }
        public TimeSpan Time { get { return _time; } }

        public virtual string GetStandardDetails()
        {
            return $"Event\nTitle: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        public virtual string GetShortDetails()
        {
            return $"{GetType().Name}: {_title} - {_date.ToShortDateString()}";
        }
    }
}