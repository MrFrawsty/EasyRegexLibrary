using System;
using Xunit;
using EasyRegexLibrary;
using System.IO;

namespace EasyRegexTests
{
    public class EasyRegexUnitTests
    {

        static string testString = Properties.Resources.RegexTestText;

        [Fact]
        public void FindCreditCardNumbersShouldFind5Results()
        {

            var results = EasyRegex.FindCreditCardNumbers(testString);

            Assert.Equal(5, results.Count);
        }

        [Fact]
        public void FindDatesShouldFind5Results()
        {

            var results = EasyRegex.FindDates(testString);

            Assert.Equal(5, results.Count);
        }

        [Fact]
        public void FindEmailAddressesShouldFind5Results()
        {

            var results = EasyRegex.FindEmailAddresses(testString);

            Assert.Equal(5, results.Count);
        }

        [Fact]
        public void FindIPAddressesShouldFind5Results()
        {

            var results = EasyRegex.FindIPAddresses(testString);

            Assert.Equal(5, results.Count);
        }

        [Fact]
        public void FindPhoneNumbersShouldFind5Results()
        {
   
            var results = EasyRegex.FindPhoneNumbers(testString);

            Assert.Equal(5, results.Count);
        }

        [Fact]
        public void FindStreetNamesShouldFind5Results()
        {

            var results = EasyRegex.FindStreetNames(testString);

            Assert.Equal(5, results.Count);
        }

        [Fact]
        public void FindURLsShouldFind5Results()
        {

            var results = EasyRegex.FindURLs(testString);

            Assert.Equal(5, results.Count);
        }

        [Fact]
        public void FindTimesShouldFind5Results()
        {

            var results = EasyRegex.FindTimes(testString);

            Assert.Equal(5, results.Count);
        }

        [Fact]
        public void FindMoneyShouldFind5Results()
        {

            var results = EasyRegex.FindUSCurrency(testString);

            Assert.Equal(5, results.Count);
        }



    }
}
