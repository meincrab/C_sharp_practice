using System;
using System.IO;

namespace Pluralize
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var lines = File.ReadAllLines("rubles.txt");
            var hasErrors = false;
            foreach (var line in lines)
            {
                var words = line.Split(' ');
                var count = int.Parse(words[0]);
                var rightAnswer = words[1];
                var pluralizedRubles = PluralizeTask.PluralizeRubles(count);
                if (pluralizedRubles != rightAnswer)
                {
                    hasErrors = true;
                    Console.WriteLine("Wrong answer: {0} {1}", count, pluralizedRubles);
                }
            }

            if (!hasErrors)
                Console.WriteLine("Correct!");
        }
    }
}