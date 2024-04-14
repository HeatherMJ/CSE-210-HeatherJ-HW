using System;

namespace OutdoorEvent
{
    public class OutdoorGatherings : Event
    {
        private string _weatherForecast;

        public OutdoorGatherings(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        public string WeatherForecast { get { return _weatherForecast; } }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nWeather Forecast: {_weatherForecast}";
        }
    }
}
