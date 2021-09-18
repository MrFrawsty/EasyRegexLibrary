using System;
using Xunit;
using EasyRegexLibrary;


namespace EasyRegexTests
{
    public class EasyRegexUnitTests
    {
        [Fact]
        public void FindWebsitesShouldReturnOneResult()
        {
            string testText = @"www.test.com wwtest.com test@email.com test.org";


            var results = EasyRegex.FindWebsites(testText);

            Assert.Equal(1, results.Count);
        }
    }
}
