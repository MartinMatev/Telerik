using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Trapezoids
{
    class Trapezoids
    {
        // Write an expression that calculates trapezoid's area by given sides a and b and height h
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter side a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Please enter side b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Please enter the height: ");
                double h = double.Parse(Console.ReadLine());

                double area = ((a + b) / 2) * h;
                Console.WriteLine("The area of the trapezoid is: {0}", area);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type in the data in the correct format!");
            }
        }
    }
}
