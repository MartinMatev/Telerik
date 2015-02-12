using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenInt
{
    class OddEven
    {
        // Write an expression that checks if given integer is odd or even.
        static void Main(string[] args)
        {
            Console.Write("Please enter your integer: ");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("It's even");
                }
                else
                {
                    Console.WriteLine("It's odd");
                }
            }
            else
            {
                Console.WriteLine("INTEGER, not whatever you just typed in.");
            }
        }
    }
}
