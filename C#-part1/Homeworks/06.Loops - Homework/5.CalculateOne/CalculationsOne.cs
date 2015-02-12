using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
// Use only one loop. Print the result with 5 digits after the decimal point.
namespace _5.CalculateOne
{
    class CalculationsOne
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type in n: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Type in n: ");
                int x = int.Parse(Console.ReadLine());
                decimal factorial = 1;
                decimal xOnDegree = 1;
                decimal sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                    xOnDegree *= x;
                    sum += (factorial / xOnDegree);
                }
                Console.WriteLine("{0:F5}", sum + 1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong data format!");
            }
        }
    }
}
