using System;
using System.Collections.Concurrent;
using System.Diagnostics.Contracts;
using System.Security.Authentication;
namespace OutdoorEvent
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }
        public string GetCompleteAddress()
        {
            return $"Street Address: {_street}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
        }
    }
}