using System;
using System.Linq;

namespace WordFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wordsInput = new string[] { "chill", "wind", "cold", "hot" };
            var columnLetters = new string[] { "abcdc", "fgwio", "chill", "pqnsd", "uvdxy" };
            var result = new WordFinder(wordsInput).Find(columnLetters);

            if(result.Count() == 0)
            {
                Console.WriteLine($"Words not found");
                return;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"Found Word: {item}");
            }            
        }
    }
}

