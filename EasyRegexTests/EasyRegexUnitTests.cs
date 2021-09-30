using System;
using Xunit;
using EasyRegexLibrary;


namespace EasyRegexTests
{
    public class EasyRegexUnitTests
    {
        [Fact]
        public void FindWebsitesShouldFindTwoResults()
        {
            string testText = @"www.test.com wwtest.com test@email.com test.org http://www.mytest.net";


            var results = EasyRegex.FindWebsites(testText);

            Assert.Equal(2, results.Count);
        }

        [Fact]
        public void FindPhoneNumbersShouldFindFiveResults()
        {
            string testText = @"6155821494 (615)-582-1494 270 558-1482 1888-730-7215 1-800-554-1788 111 111 1111";


            var results = EasyRegex.FindPhoneNumbers(testText);

            Assert.Equal(5, results.Count);
        }

        [Fact]
        public void FindCreditCardNumbersShouldFind2Results()
        {
            string testText = @"4144 2555 4254 7958 7011-4885-0558-055";


            var results = EasyRegex.FindCreditCardNumbers(testText);

            Assert.Equal(2, results.Count);
        }

        [Fact]
        public void FindStreetAddress()
        {
            string testText = @"4144 2555 4254 7958 7011-4885-0558-055";


            var results = EasyRegex.FindCreditCardNumbers(testText);

            Assert.Equal(2, results.Count);
        }

    }
}
