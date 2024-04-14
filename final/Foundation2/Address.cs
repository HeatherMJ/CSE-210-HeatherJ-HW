using System;


namespace OnlineOrdering
{
    public class Address
    {
        private string _streetAddress;
        private string _city; 
        private string _state; 
        private string _country;
        public Address(string streetAddress, string city, string state, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _state = state;
            _country = country;
        }
        public bool USA()
        {
            return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }
        public string GetCompleteAddress()
       {
         return $"Street Address: {_streetAddress}\nCity: {_city}\nState/Province: {_state}\nCountry: {_country}";
       }
    }  
}