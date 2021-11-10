using System;
using Xunit;
using System.Collections.Generic;
using System.Text;

namespace CustomerClassLibrary.Tests
{
    public class AddressValidatorTests
    {
        [Fact]
        public void ShouldReturnCorrectResultAddressLineWithoutValue()
        {
            Address address = new Address("", "awdad", AddressType.Billing, "feaf", "167023", "qqwd", "Canada");
            Assert.Equal(new List<string> { "Address line is REQUIRED" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultAddressLineValueOver100()
        {
            var str = new StringBuilder();
            str.Length = 101;
            Address address = new Address(str.ToString(), "awdad", AddressType.Billing, "feaf", "167023", "qqwd", "Canada");
            Assert.Equal(new List<string> { "The maximum length of 'Address Line' is 100 characters" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultAddressLine2ValueOver100()
        {
            var str = new StringBuilder();
            str.Length = 101;
            Address address = new Address("awdaw", str.ToString(), AddressType.Billing, "feaf", "167023", "qqwd", "Canada");
            Assert.Equal(new List<string> { "The maximum length of 'Address Line 2' is 100 characters" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultAddressTypeValueIncorrect()
        {
            Address address = new Address("awdaw", "awdawd", AddressType.Billing, "feaf", "167023", "qqwd", "Canada");
            Assert.True(Enum.IsDefined(typeof(AddressType), address.AddressType));
        }

        [Fact]
        public void ShouldReturnCorrectResultCityWithoutValue()
        {
            Address address = new Address("adwd", "awdad", AddressType.Billing, "", "167023", "qqwd", "Canada");
            Assert.Equal(new List<string> { "City is REQUIRED" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultCityValueOver50()
        {
            var str = new StringBuilder();
            str.Length = 51;
            Address address = new Address("awdwad", "awdad", AddressType.Billing, str.ToString(), "167023", "qqwd", "Canada");
            Assert.Equal(new List<string> { "The maximum length of 'City' is 50 characters" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultPostalCodeWithoutValue()
        {
            Address address = new Address("adwd", "awdad", AddressType.Billing, "add", "", "qqwd", "Canada");
            Assert.Equal(new List<string> { "Postal Code is REQUIRED" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultPostalCodeValueOver6()
        {
            var str = new StringBuilder();
            str.Length = 7;
            Address address = new Address("awdwad", "awdad", AddressType.Billing, "dwad", str.ToString(), "qqwd", "Canada");
            Assert.Equal(new List<string> { "The maximum length of 'Postal Code' is 6 characters" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultStateWithoutValue()
        {
            Address address = new Address("adwd", "awdad", AddressType.Billing, "add", "167023", "", "Canada");
            Assert.Equal(new List<string> { "State is REQUIRED" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultStateValueOver6()
        {
            var str = new StringBuilder();
            str.Length = 21;
            Address address = new Address("awdwad", "awdad", AddressType.Billing, "dwad", "167023", str.ToString(), "Canada");
            Assert.Equal(new List<string> { "The maximum length of 'State' is 20 characters" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultCountryWithoutValue()
        {
            Address address = new Address("adwd", "awdad", AddressType.Billing, "add", "167023", "awda", "");
            Assert.Equal(new List<string> { "Country is REQUIRED" }, AddressValidator.Validate(address));
        }

        [Fact]
        public void ShouldReturnCorrectResultCountryIsNotUsaOrCanada()
        {
            Address address = new Address("adwd", "awdad", AddressType.Billing, "add", "167023", "awda", "Russia");
            Assert.Equal(new List<string> { "'Country' should equals to 'United States' or 'Canada'" }, AddressValidator.Validate(address));
        }
    }
}
