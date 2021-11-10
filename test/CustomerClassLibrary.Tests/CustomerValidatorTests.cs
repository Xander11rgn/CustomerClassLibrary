using System;
using Xunit;
using System.Collections.Generic;
using System.Text;

namespace CustomerClassLibrary.Tests
{
    public class CustomerValidatorTests
    {
        Address address = new Address("adwd", "awdad", AddressType.Billing, "feaf", "167023", "qqwd", "Canada");
        [Fact]
        public void ShouldReturnCorrectResultFirstNameWithoutValue()
        {
            Customer customer = new Customer("", "awdaw", new List<Address> { address }, "+8489984", "awd@dwad.dwda", new List<string> { "dwada" }, 5646.4);
            Assert.Equal(new List<string> { }, CustomerValidator.Validate(customer));
        }

        [Fact]
        public void ShouldReturnCorrectResultFirstNameValueOver50()
        {
            var str = new StringBuilder();
            str.Length = 51;
            Customer customer = new Customer(str.ToString(), "awdaw", new List<Address> { address }, "+8489984", "awd@dwad.dwda", new List<string> { "dwada" }, 5646.4);
            Assert.Equal(new List<string> { "The maximum length of 'First Name' is 50 characters" }, CustomerValidator.Validate(customer));
        }


        [Fact]
        public void ShouldReturnCorrectResultLastNameWithoutValue()
        {
            Customer customer = new Customer("adwad", "", new List<Address> { address }, "+8489984", "awd@dwad.dwda", new List<string> { "dwada" }, 5646.4);
            Assert.Equal(new List<string> { "Last Name is REQUIRED" }, CustomerValidator.Validate(customer));
        }

        [Fact]
        public void ShouldReturnCorrectResultLastNameValueOver50()
        {
            var str = new StringBuilder();
            str.Length = 51;
            Customer customer = new Customer("awdaa", str.ToString(), new List<Address> { address }, "+8489984", "awd@dwad.dwda", new List<string> { "dwada" }, 5646.4);
            Assert.Equal(new List<string> { "The maximum length of 'Last Name' is 50 characters" }, CustomerValidator.Validate(customer));
        }


        [Fact]
        public void ShouldReturnCorrectResultAddressesListEmpty()
        {
            Customer customer = new Customer("adwad", "adawa", new List<Address> { }, "+8489984", "awd@dwad.dwda", new List<string> { "dwada" }, 5646.4);
            Assert.Equal(new List<string> { "There should be at least 1 address" }, CustomerValidator.Validate(customer));
        }

        [Theory]
        [InlineData("+4897878498498765156489784")]
        [InlineData("+22a239f7e84")]
        [InlineData("+")]
        public void ShouldReturnCorrectResultIncorrectPhoneFormat(string value)
        {
            Customer customer = new Customer("adwad", "adawa", new List<Address> { address }, value, "awd@dwad.dwda", new List<string> { "dwada" }, 5646.4);
            Assert.Equal(new List<string> { "Customer Phone Number is in the incorrect format (E.164)" }, CustomerValidator.Validate(customer));
        }


        [Theory]
        [InlineData("awdaw awd   awd  @awdaw . wwad")]
        [InlineData("afaf@.awd")]
        [InlineData("awdad@awdwad")]
        public void ShouldReturnCorrectResultIncorrectMailFormat(string value)
        {
            Customer customer = new Customer("adwad", "adawa", new List<Address> { address }, "+8489984", value, new List<string> { "dwada" }, 5646.4);
            Assert.Equal(new List<string> { "Customer Mail is in the incorrect format (smth@smth.smth)" }, CustomerValidator.Validate(customer));
        }


        [Fact]
        public void ShouldReturnCorrectResultNotesListEmpty()
        {
            Customer customer = new Customer("adwad", "adawa", new List<Address> { address }, "+8489984", "awd@dwad.dwda", new List<string> { }, 5646.4);
            Assert.Equal(new List<string> { "There should be at least 1 note" }, CustomerValidator.Validate(customer));
        }
    }
}
