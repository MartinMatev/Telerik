using System;
using System.Linq;

namespace _07.LongestString
{
    class StringTests
    {
        static void Main()
        {
            /*
             * Problem 17. Longest string
             * Write a program to return the string with maximum length from an array of strings.
             * Use LINQ.
             */
            
            string[] stringArray = new[] { "Small", "SomeWhatLong", "TheLongestOfThemAll", "lel" };

            var allStrings = from str in stringArray 
                                orderby str.Length descending
                                select str;
            var longestString = allStrings.FirstOrDefault();

            // The same operation using Lambda expressions

            //var longestString = stringArray
            //                    .GroupBy(str => str.Length)
            //                    .OrderByDescending(grp => grp.Key)
            //                    .First()
            //                    .ToList();

            Console.WriteLine("Longest string: {0}", string.Join(", ", longestString));
        }
    }
}
