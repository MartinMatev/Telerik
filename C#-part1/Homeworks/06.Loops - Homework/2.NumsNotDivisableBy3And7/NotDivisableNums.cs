using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that enters from the console a positive integer n 
// and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space
namespace _2.NumsNotDivisableBy3And7
{
    class NotDivisableNums
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive int: ");
            uint number;
            if (uint.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 0; i <= number; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
        }
    }
}
