using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using FluentValidation;

namespace CustomerClassLibrary
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.FirstName).MaximumLength(50).WithMessage("The maximum length of 'First Name' is 50 characters");
            RuleFor(customer => customer.LastName).NotEmpty().WithMessage("Last Name is REQUIRED").MaximumLength(50).WithMessage("The maximum length of 'Last Name' is 50 characters");
            RuleFor(customer => customer.AddressesList).NotEmpty().WithMessage("There should be at least 1 address");
            RuleFor(customer => customer.CustomerPhoneNumber).Must(phone => Regex.IsMatch(phone, @"^\+\d{1,15}$")).WithMessage("Customer Phone Number is in the incorrect format (E.164)");
            RuleFor(customer => customer.CustomerMail).Must(mail => Regex.IsMatch(mail, @"^\S+@\S+\.\S+$")).WithMessage("Customer Mail is in the incorrect format (smth@smth.smth)");
            RuleFor(customer => customer.Notes).NotEmpty().WithMessage("There should be at least 1 note");
            RuleFor(customer => customer.TotalPurchasesAmount).NotNull();
        }
    }
}
