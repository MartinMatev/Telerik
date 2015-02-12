using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PrimeNumberCheck
{
    class PrimeNumber
    {
        // Write an expression that checks if given positive integer number n (n = 100) 
        // is prime (i.e. it is divisible without remainder only to itself and 1)
        static void Main(string[] args)
        {
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(number);
                // True by default, unless the number entered is negative
                bool isPrime = number > 0;
                // A while loop used to cycle through all the numbers up until the condition in the while parantheses is false 
                while (isPrime && divider <= maxDivider)
                {
                    // If during the cycle we find out that the number can be divided with a remainder of 0
                    // sets the isPrime to false, meaning that the given number is not Prime
                    if (number % divider == 0)
                    {
                        isPrime = false;
                    }
                    divider++;
                }
                Console.WriteLine("Is your number prime? : {0}", isPrime);
            }
            else
            {
                Console.WriteLine("That's not an integer.");
            }
        }
    }
}
