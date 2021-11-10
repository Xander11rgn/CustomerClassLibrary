using System;
using System.Collections.Generic;

namespace CustomerClassLibrary
{
    public class Customer : Person
    {
        private string _firstName;
        public override string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;
        public override string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private List<Address> _addressesList;
        public List<Address> AddressesList
        {
            get => _addressesList;
            set => _addressesList = value;
        }

        private string _customerPhoneNumber;
        public string CustomerPhoneNumber
        {
            get => _customerPhoneNumber;
            set => _customerPhoneNumber = value;
        }

        private string _customerMail;
        public string CustomerMail
        {
            get => _customerMail;
            set => _customerMail = value;
        }

        private List<string> _notes;
        public List<string> Notes
        {
            get => _notes;
            set => _notes = value;
        }

        private double _totalPurchasesAmount;
        public double TotalPurchasesAmount
        {
            get => _totalPurchasesAmount;
            set => _totalPurchasesAmount = value;
        }

        public Customer(string firstName, string lastName, List<Address> addressesList, string customerPhoneNumber, string customerMail, List<string> notes, double totalPurchasesAmount)
        {
            FirstName = firstName;
            LastName = lastName;
            AddressesList = addressesList;
            CustomerPhoneNumber = customerPhoneNumber;
            CustomerMail = customerMail;
            Notes = notes;
            TotalPurchasesAmount = totalPurchasesAmount;
        }
    }
}
