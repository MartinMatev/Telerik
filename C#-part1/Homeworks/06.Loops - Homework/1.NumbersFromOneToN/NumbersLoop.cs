using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that enters from the console a positive integer n and 
// prints all the numbers from 1 to n, on a single line, separated by a space.
namespace _1.NumbersFromOneToN
{
    class NumbersLoop
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the last number(int): ");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
    }
}
