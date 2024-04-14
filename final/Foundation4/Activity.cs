using System;
namespace Activity
{ 
    public abstract class Activity
    {
        private DateTime _date;
        private int duration;
        
        public Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;

        public Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }
        public virtual double GetDistance()
        {
            return 0;
        }
        }
        public abstract double GetSpeed()
        {
            return 0;
        }
        public abstract double GetPace();
        {
            return 0;
        }
        public string GetSummary()
        {
            return $"{_date.ToShortDateString()}" {_duration} min";
        }
    }
}