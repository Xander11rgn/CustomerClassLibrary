using System;
using Xunit;
using System.Collections.Generic;
using System.Text;

namespace CustomerClassLibrary.Tests
{
    public class CustomerValidatorTests
    {
        CustomerValidator customerValidator = new CustomerValidator();
        Address address = new Address("awdaw", "wdada", AddressType.Billing, "wadaw", "167023", "wdad", "Canada");

        [Fact]
        public void ShouldBeAbleToCreateCustomerValidatorObject()
        {
            AddressValidator addressValidator = new AddressValidator();
            Assert.NotNull(addressValidator);
        }

        
        [Fact]
        public void ShouldReturnCorrectResultFirstNameOver50()
        {
            var str = new StringBuilder();
            str.Length = 51;
            Customer customer = new Customer(str.ToString(), "wdadawd", new List<Address> { address }, "+846486", "awda@adw.afa", new List<string> { "dwada" }, 5464.20);
            var result = customerValidator.Validate(customer).Errors;
            Assert.Equal("The maximum length of 'First Name' is 50 characters", result[0].ErrorMessage);
        }


        [Fact]
        public void ShouldReturnCorrectResultLastNameEmpty()
        {
            Customer customer = new Customer("dwada", "", new List<Address> { address }, "+846486", "awda@adw.afa", new List<string> { "dwada" }, 5464.20);
            var result = customerValidator.Validate(customer).Errors;
            Assert.Equal("Last Name is REQUIRED", result[0].ErrorMessage);
        }

        [Fact]
        public void ShouldReturnCorrectResultLastNameOver50()
        {
            var str = new StringBuilder();
            str.Length = 51;
            Customer customer = new Customer("dawdw", str.ToString(), new List<Address> { address }, "+846486", "awda@adw.afa", new List<string> { "dwada" }, 5464.20);
            var result = customerValidator.Validate(customer).Errors;
            Assert.Equal("The maximum length of 'Last Name' is 50 characters", result[0].ErrorMessage);
        }


        [Fact]
        public void ShouldReturnCorrectResultAddressesListEmpty()
        {
            Customer customer = new Customer("dawdw", "dwadwad", new List<Address> { }, "+846486", "awda@adw.afa", new List<string> { "dwada" }, 5464.20);
            var result = customerValidator.Validate(customer).Errors;
            Assert.Equal("There should be at least 1 address", result[0].ErrorMessage);
        }


        [Fact]
        public void ShouldReturnCorrectResultIncorrectPhone()
        {
            Customer customer = new Customer("dawdw", "dwadwad", new List<Address> { address }, "+84awd6aw48w6", "awda@adw.afa", new List<string> { "dwada" }, 5464.20);
            var result = customerValidator.Validate(customer).Errors;
            Assert.Equal("Customer Phone Number is in the incorrect format (E.164)", result[0].ErrorMessage);
        }


        [Fact]
        public void ShouldReturnCorrectResultIncorrectMail()
        {
            Customer customer = new Customer("dawdw", "dwadwad", new List<Address> { address }, "+846486", "aw   da @a dw.afa", new List<string> { "dwada" }, 5464.20);
            var result = customerValidator.Validate(customer).Errors;
            Assert.Equal("Customer Mail is in the incorrect format (smth@smth.smth)", result[0].ErrorMessage);
        }

        [Fact]
        public void ShouldReturnCorrectResultNotesListEmpty()
        {
            Customer customer = new Customer("dawdw", "dwadwad", new List<Address> { address }, "+846486", "awda@adw.afa", new List<string> { }, 5464.20);
            var result = customerValidator.Validate(customer).Errors;
            Assert.Equal("There should be at least 1 note", result[0].ErrorMessage);
        }


        [Fact]
        public void ShouldReturnCorrectResultTotalPurchaseAmountNull()
        {
            Customer customer = new Customer("dawdw", "dwadwad", new List<Address> { address }, "+846486", "awda@adw.afa", new List<string> { "rdgdrg" }, null);
            var result = customerValidator.Validate(customer).Errors;
            Assert.Empty(result);
        }
    }
}
