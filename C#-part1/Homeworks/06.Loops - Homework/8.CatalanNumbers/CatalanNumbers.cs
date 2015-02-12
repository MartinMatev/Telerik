using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
// Write a program to calculate the nth Catalan number by given n (1 < n < 100).
namespace _8.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n;
            bool isParsed = false;
            BigInteger factorialN = 1;
            BigInteger factorialNProduct = 1;
            BigInteger factorialNPlusOne = 1;

            do
            {
                Console.Write("(1).Type in n (1 < n < 100): ");
                isParsed = int.TryParse(Console.ReadLine(), out n);
            }
            while (!isParsed || n < 1 || n > 100);

            for (int i = 1; i <= 2 * n; i++)
            {
                if (i <= n)
                {
                    factorialN *= i;
                }
                if (i <= n + 1)
                {
                    factorialNPlusOne *= i;
                }
                factorialNProduct *= i;
            }
            BigInteger equation = factorialNProduct / (factorialNPlusOne * factorialN);
            Console.WriteLine("The answer to the equation is : {0}", equation);
        }
    }
}
