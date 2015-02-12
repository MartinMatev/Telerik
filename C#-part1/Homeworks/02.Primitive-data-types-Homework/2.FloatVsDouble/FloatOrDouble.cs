using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FloatVsDouble
{
    class FloatOrDouble
    {
        // Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
        // Write a program to assign the numbers in variables and print them to ensure no precision is lost.
        static void Main(string[] args)
        {
            double numberOne = 34.567839023;
            float numberTwo = 12.345f;
            double numberThree = 8923.1234857;
            float numberFour = 3456.091f;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", numberOne, numberTwo, numberThree, numberFour);
        }
    }
}
