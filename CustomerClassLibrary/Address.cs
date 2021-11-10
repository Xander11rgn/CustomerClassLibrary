using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerClassLibrary
{
    public class Address
    {
        private string _addressLine;
        public string AddressLine
        {
            get => _addressLine;
            set => _addressLine = value;
        }

        private string _addressLine2;
        public string AddressLine2
        {
            get => _addressLine2;
            set => _addressLine2 = value;
        }

        AddressType _addressType;
        public AddressType AddressType
        {
            get => _addressType;
            set => _addressType = value;
        }

        private string _city;
        public string City
        {
            get => _city;
            set => _city = value;
        }

        private string _postalCode;
        public string PostalCode
        {
            get => _postalCode;
            set => _postalCode = value;
        }

        private string _state;
        public string State
        {
            get => _state;
            set => _state = value;
        }

        private string _country;
        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public Address(string addressLine, string addressLine2, AddressType addressType, string city, string postalCode, string state, string country)
        {
            AddressLine = addressLine;
            AddressLine2 = addressLine2;
            AddressType = addressType;
            City = city;
            PostalCode = postalCode;
            State = state;
            Country = country;
        }
    }
}
