using System;
using System.Runtime.Loader;
namespace OnlineOrdering
{
    public class Customer
    {
        private string _customername;
        private Address _address;
        
        public string customerName {get => _customername; set => customerName = value; }
         public Address Address { get => _address; set => _address = value; }


        public Customer(string customerName, Address address)
        {
            _customername = customerName;
            _address = address;
        }
        public bool USA()
        {
            return Address.USA();
        }
    }

}