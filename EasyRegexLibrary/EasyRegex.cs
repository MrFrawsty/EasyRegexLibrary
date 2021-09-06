using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EasyRegexLibrary
{
    public static class EasyRegex
    {  
        public static MatchCollection FindCreditCardNumbers(string text)
        {   
            return new Regex(@"\b\d{4}(\s|-)?\d{4}(\s|-)?\d{4}(\s|-)?\d{2,4}\b").Matches(text);
        }

        public static MatchCollection FindDates(string text)
        {
            return new Regex(@"\b(?:[0-9]{1}|[0-9]{2})[-/\s](?:[0-9]{1}|[0-9]{2})[-/\s](?:[0-9]{2}|[0-9]{4})\b").Matches(text);
        }

        public static MatchCollection FindEmailAddresses(string text)
        {
            return new Regex(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b", RegexOptions.IgnoreCase).Matches(text);
               
        }

        public static MatchCollection FindIPAddresses(string text)
        {
            return new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b").Matches(text);
        }

        public static MatchCollection FindMoney(string text)
        {
            return new Regex(@"\$?[0-9]{1,3}(?:\,|\.)?[0-9]{1,3}?(?:\,|\.)?[0-9]{1,3}(?:\,|\.)?[0-9]{1,3}(?:\,|\.)?[0-9]{1,3}", RegexOptions.IgnoreCase).Matches(text);
        }
 
        public static MatchCollection FindPhoneNumbers(string text)
        {
            return new Regex(@"1?-?\(?[0-9]{3}\)?(-|\s)[0-9]{3}(-|\s)[0-9]{4}", RegexOptions.IgnoreCase).Matches(text);    
        }

        public static MatchCollection FindStreetAddresses(string text)
        {
            
           return new Regex(@"\b[0-9-]{1,7}\s(?:\w{1,20}|[0-9]{1,7})[\s-,]+?(?:\w{1,20}|[0-9]{1,7})?[\s-,]+(?:\w{1,20}|[0-9]{1,7})?[\s-,]+?(?:\w{1,20}|[0-9]{1,7})?[\s-,]+(?:\w{1,20}|[0-9]{1,7})?[\s-,]+?([0-9]{1,20}|[0-9]{1,7})?[\s-,]?[0-9-]{1,11}\b")
               .Matches(text);
        } 

        public static MatchCollection FindTimes(string text)
        {
            return new Regex(@"\b[0-9]{1,2}:[0-9]{2}(am|pm)?\b",RegexOptions.IgnoreCase).Matches(text);
        }

        public static MatchCollection FindWebsites(string text)
        {
            return new Regex(@"\b(http:\/\/)?(www)?\.?\w{1,256}\.\w{1,10}\.?\w{1,10}?\b", RegexOptions.IgnoreCase).Matches(text);
        }

        public static MatchCollection MatchWord(string word, string text)
        {
            
            return new Regex($@"{word}", RegexOptions.IgnoreCase).Matches(text);
        }

        public static bool VerifyContains(MatchCollection matches)
        {
          if(matches.Count > 0)
            {
                return true;
            }
          else
            {
                return false;
            }
 
        }

        public static MatchCollection ReadFromFile(string filePath, Func<string, MatchCollection> searchMethod)
        {
            using StreamReader reader = new StreamReader(filePath);
            var content = reader.ReadToEnd();
            return searchMethod.Invoke(content);
        }

        public static async Task<MatchCollection> ReadFromFileAsync(string filePath, Func<string, MatchCollection> searchMethod)
        {
            using StreamReader reader = new StreamReader(filePath);
            var content = await reader.ReadToEndAsync();
            return searchMethod.Invoke(content);
        }

    }
}
