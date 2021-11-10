using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerClassLibrary
{
    public class AddressValidator
    {
        public static List<string> Validate(Address addressObj)
        {
            List<string> errors = new List<string>();

            if (addressObj.AddressLine.Length == 0)
            {
                errors.Add("Address line is REQUIRED");                
            }
            else if (addressObj.AddressLine.Length > 100)
            {
                errors.Add("The maximum length of 'Address Line' is 100 characters");
            }


            
            if (addressObj.AddressLine2.Length > 100)
            {
                errors.Add("The maximum length of 'Address Line 2' is 100 characters");
            }


            if (addressObj.City.Length == 0)
            {
                errors.Add("City is REQUIRED");
            }
            else if (addressObj.City.Length > 50)
            {
                errors.Add("The maximum length of 'City' is 50 characters");
            }


            if (addressObj.PostalCode.Length == 0)
            {
                errors.Add("Postal Code is REQUIRED");
            }
            else if (addressObj.PostalCode.Length > 6)
            {
                errors.Add("The maximum length of 'Postal Code' is 6 characters");
            }


            if (addressObj.State.Length == 0)
            {
                errors.Add("State is REQUIRED");
            }
            else if (addressObj.State.Length > 20)
            {
                errors.Add("The maximum length of 'State' is 20 characters");
            }


            if (addressObj.Country.Length == 0)
            {
                errors.Add("Country is REQUIRED");
            }
            else if ((addressObj.Country != "United States") && (addressObj.Country != "Canada"))
            {
                errors.Add("'Country' should equals to 'United States' or 'Canada'");
            }


            return errors;
        }
    }
}
