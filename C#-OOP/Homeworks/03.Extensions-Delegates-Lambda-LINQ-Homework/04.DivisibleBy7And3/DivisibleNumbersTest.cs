using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.DivisibleBy7And3
{
    class DivisibleNumbersTest
    {
        static void Main()
        {
            /*Problem 6. Divisible by 7 and 3
             * Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
             * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
             */ 

            int[] numbersArray = new int[] { 7, 3, 21, 14, 6, 105 };

            var result = numbersArray.Where(x => x % 3 == 0 && x % 7 == 0).ToArray();
            Console.WriteLine("Using built-in extension methods and lambda expressions: ");
            PrintResult(result);

            var linqResult = from number in numbersArray
                             where number % 3 == 0 && number % 7 == 0
                             select number;
            Console.WriteLine("\nUsing LINQ");
            PrintResult(linqResult);
        }

        private static void PrintResult<T>(IEnumerable<T> collection)
        {
            foreach (var number in collection)
            {
                Console.WriteLine(number);
            }
        }
    }
}
