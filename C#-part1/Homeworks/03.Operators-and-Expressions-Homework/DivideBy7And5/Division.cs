using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class Division
    {
        // Write a Boolean expression that checks for given integer 
        // if it can be divided (without remainder) by 7 and 5 at the same time.
        static void Main(string[] args)
        {
            int input;
            Console.Write("Enter your number: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                // Returns true if the input is both dividable by 7 and 5 without remainder
                bool isTrue = input % 7 == 0 && input % 5 == 0;
                Console.WriteLine("Does your number divide by 7 and 5 at the same time? : {0}", isTrue);
            }
        }
    }
}
