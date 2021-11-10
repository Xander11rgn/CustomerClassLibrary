using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomerClassLibrary
{
    public class CustomerValidator
    {
        public static List<string> Validate(Customer customerObj)
        {
            List<string> errors = new List<string>();

            if (customerObj.FirstName.Length > 50)
            {
                errors.Add("The maximum length of 'First Name' is 50 characters");
            }


            if (customerObj.LastName.Length == 0)
            {
                errors.Add("Last Name is REQUIRED");
            }
            else if (customerObj.LastName.Length > 50)
            {
                errors.Add("The maximum length of 'Last Name' is 50 characters");
            }


            if (customerObj.AddressesList.Count == 0)
            {
                errors.Add("There should be at least 1 address");
            }

            
            if (!Regex.IsMatch(customerObj.CustomerPhoneNumber, @"^\+\d{1,15}$"))
            {
                errors.Add("Customer Phone Number is in the incorrect format (E.164)");
            }


            if (!Regex.IsMatch(customerObj.CustomerMail, @"^\S+@\S+\.\S+$"))
            {
                errors.Add("Customer Mail is in the incorrect format (smth@smth.smth)");
            }


            if (customerObj.Notes.Count == 0)
            {
                errors.Add("There should be at least 1 note");
            }

            if (customerObj.TotalPurchasesAmount == null)
            {
                customerObj.TotalPurchasesAmount = 0;
            }

            return errors;
        }
    }
}
