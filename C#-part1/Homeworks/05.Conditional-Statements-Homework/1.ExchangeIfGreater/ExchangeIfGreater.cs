using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
// As a result print the values a and b, separated by a space.
namespace _1.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                // Checks if the first is bigger than the second one, and exchanges their values using a temporary variable if so.
                if (a > b)
                {
                    double temp = a;
                    a = b;
                    b = temp;
                    Console.WriteLine("Values exchanged : a = {0}; b = {1}", a, b);
                }
                else
                {
                    Console.WriteLine("a = {0}; b = {1}", a, b);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong data format!");
            }
        }
    }
}
