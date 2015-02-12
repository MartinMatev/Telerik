using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SquareRoot
{
    class SquareRoot
    {
        //Create a console application that calculates and prints the square root of the number 12345
        static void Main(string[] args)
        {
            int number = 12345;
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is {1}", number, squareRoot);
        }
    }
}
