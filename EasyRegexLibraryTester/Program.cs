using System;
using EasyRegexLibrary;

namespace EasyRegexLibraryTester
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\kenny\Desktop\EasyRegexText.txt";

            var result = EasyRegexCollections.ReadFromFile(filePath, EasyRegexCollections.FindIPAddresses).Result;
         
       
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
