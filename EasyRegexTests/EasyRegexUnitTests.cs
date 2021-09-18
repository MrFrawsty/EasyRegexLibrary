using System;
using Xunit;
using EasyRegexLibrary;
using System.Collections;

namespace EasyRegexTests
{
    public class EasyRegexUnitTests
    {
        [Fact]
        public void FindWebsitesShouldHaveOneResult()
        {
           string testText = @"wwwwebsitecom .com test@email.com www,my-site dfs.dsfsfsfs  http://www.mywebsite.com ";

           var results = EasyRegex.FindURLs(testText);
 
            Assert.Equal(1, results.Count);


        }
       
    }
}
