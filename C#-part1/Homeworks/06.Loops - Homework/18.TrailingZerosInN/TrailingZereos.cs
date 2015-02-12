using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
// Your program should work well for very big numbers, e.g. n=100000.
namespace _18.TrailingZerosInN
{
    class TrailingZereos
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer number: ");
            int number;
            int counter = 0;
            int sum = 0;
            BigInteger factorial = 1;

            
            if (int.TryParse(Console.ReadLine(), out number))
            {
                //  Option 1: Using "de Polignac's formula" (without calculating the actual factorial of the number):
                // It's a lot, a lot faster the the other option. Like me during "naughty time" fast... :(
                for (int i = 1; i <= number; i++)
                {
                    int pow = (int)Math.Pow(5, i);
                    if (pow > number)
                    {
                        break;
                    }
                    sum += number / pow;
                }
                Console.WriteLine("The number of trailing zeroes is: {0}", sum);

                // Option 2: For bigger numbers (such as 100 000) it takes some time.It works tho, so it got that going for it, which is nice.
                /*
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                foreach (char digit in factorial.ToString())
                {
                    if (digit == '0')
                    {
                        counter++;
                    }
                    if (digit != '0')
                    {
                        counter = 0;
                    }
                }
                Console.WriteLine("The number of trailing zeroes is: {0}", counter);
                */
            }
        }
    }
}
