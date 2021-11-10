using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerClassLibrary.Tests
{
    public class AddressValidatorTests
    {
        AddressValidator addressValidator = new AddressValidator();

        [Fact]
        public void ShouldBeAbleToCreateAddressValidatorObject()
        {
            AddressValidator addressValidator = new AddressValidator();
            Assert.NotNull(addressValidator);
        }

        [Fact]
        public void ShouldReturnCorrectResultAddressLineEmpty()
        {
            Address address = new Address("", "wdada", AddressType.Billing, "wadaw", "167023", "wdad", "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("Address line is REQUIRED", result[0].ErrorMessage);
        }

        [Fact]
        public void ShouldReturnCorrectResultAddressLineOver100()
        {
            var str = new StringBuilder();
            str.Length = 101;
            Address address = new Address(str.ToString(), "wdada", AddressType.Billing, "wadaw", "167023", "wdad", "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("The maximum length of 'Address Line' is 100 characters", result[0].ErrorMessage);
        }

        [Fact]
        public void ShouldReturnCorrectResultAddressLine2Over100()
        {
            var str = new StringBuilder();
            str.Length = 101;
            Address address = new Address("wdada", str.ToString(), AddressType.Billing, "wadaw", "167023", "wdad", "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("The maximum length of 'Address Line 2' is 100 characters", result[0].ErrorMessage);
        }


        [Fact]
        public void ShouldReturnCorrectResultIncorrectAddressType()
        {
            Address address = new Address("adwa", "wdada", AddressType.Billing, "adwad", "167023", "awdawd", "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.True(result.Count == 0);
        }


        [Fact]
        public void ShouldReturnCorrectResultCityEmpty()
        {
            Address address = new Address("adwa", "wdada", AddressType.Billing, "", "167023", "wdad", "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("City is REQUIRED", result[0].ErrorMessage);
        }

        [Fact]
        public void ShouldReturnCorrectResultCityOver50()
        {
            var str = new StringBuilder();
            str.Length = 51;
            Address address = new Address("dwadad", "wdada", AddressType.Billing, str.ToString(), "167023", "wdad", "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("The maximum length of 'City' is 50 characters", result[0].ErrorMessage);
        }


        [Fact]
        public void ShouldReturnCorrectResultPostalCodeEmpty()
        {
            Address address = new Address("adwa", "wdada", AddressType.Billing, "adwad", "", "wdad", "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("Postal Code is REQUIRED", result[0].ErrorMessage);
        }

        [Fact]
        public void ShouldReturnCorrectResultPostalCodeOver6()
        {
            var str = new StringBuilder();
            str.Length = 7;
            Address address = new Address("dwadad", "wdada", AddressType.Billing, "dwadawd", str.ToString(), "wdad", "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("The maximum length of 'Postal Code' is 6 characters", result[0].ErrorMessage);
        }


        [Fact]
        public void ShouldReturnCorrectResultStateEmpty()
        {
            Address address = new Address("adwa", "wdada", AddressType.Billing, "adwad", "167023", "", "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("State is REQUIRED", result[0].ErrorMessage);
        }

        [Fact]
        public void ShouldReturnCorrectResultStateOver20()
        {
            var str = new StringBuilder();
            str.Length = 21;
            Address address = new Address("dwadad", "wdada", AddressType.Billing, "awdaw", "167023", str.ToString(), "Canada");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("The maximum length of 'State' is 20 characters", result[0].ErrorMessage);
        }


        [Fact]
        public void ShouldReturnCorrectResultCountryEmpty()
        {
            Address address = new Address("adwa", "wdada", AddressType.Billing, "adwad", "167023", "awdawd", "");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("Country is REQUIRED", result[0].ErrorMessage);
        }

        [Fact]
        public void ShouldReturnCorrectResultCountryIsNotInUsaOrCanada()
        {
            Address address = new Address("dwadad", "wdada", AddressType.Billing, "awdaw", "167023", "dawd", "Russia");
            var result = addressValidator.Validate(address).Errors;
            Assert.Equal("'Country' should equals to 'United States' or 'Canada'", result[0].ErrorMessage);
        }

    }
}
