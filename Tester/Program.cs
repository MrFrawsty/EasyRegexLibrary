using System;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello, this is a test. My name is Kenny and I have $5.00. kennyjoec@gmail.com Also written as $5";
            var matches = EasyRegexLibrary.EasyRegex.FindMoney(test);
            foreach (var item in matches)
            {
                Console.WriteLine(item.ToString()) ;
            }
            Console.ReadLine();
            
        }
    }
}
