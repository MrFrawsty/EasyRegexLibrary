using EasyRegexLibrary;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            string filePath = @"C:\Users\kenny\Desktop\EasyRegexText.txt";
            var results = await EasyRegex.ReadFromFileAsync(filePath, EasyRegex.FindEmailAddresses);
            Console.WriteLine(results);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

        }
    }
}
