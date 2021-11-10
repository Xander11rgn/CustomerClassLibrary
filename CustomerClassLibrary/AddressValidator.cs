using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CustomerClassLibrary
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(customer => customer.AddressLine).NotEmpty().WithMessage("Address line is REQUIRED").MaximumLength(100).WithMessage("The maximum length of 'Address Line' is 100 characters");
            RuleFor(customer => customer.AddressLine2).MaximumLength(100).WithMessage("The maximum length of 'Address Line 2' is 100 characters");
            RuleFor(customer => customer.AddressType).IsInEnum();
            RuleFor(customer => customer.City).NotEmpty().WithMessage("City is REQUIRED").MaximumLength(50).WithMessage("The maximum length of 'City' is 50 characters");
            RuleFor(customer => customer.PostalCode).NotEmpty().WithMessage("Postal Code is REQUIRED").MaximumLength(6).WithMessage("The maximum length of 'Postal Code' is 6 characters");
            RuleFor(customer => customer.State).NotEmpty().WithMessage("State is REQUIRED").MaximumLength(20).WithMessage("The maximum length of 'State' is 20 characters");
            RuleFor(customer => customer.Country).NotEmpty().WithMessage("Country is REQUIRED").Must(country => country.Equals("United States") || country.Equals("Canada")).WithMessage("'Country' should equals to 'United States' or 'Canada'");
        }
    }
}
