using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.
namespace _6.CalculateTwo
{
    class CalculationsTwo
    {
        static void Main(string[] args)
        {
            int k;
            int n;
            bool isParsed = false;
            decimal factorialN = 1;
            decimal factorialK = 1;
            // A loop for data check. Saves time, looks cool, doesnt count towards the "One loop limit"...I think
            do 
            {
                Console.Write("(1).Type in n (1 < n < 100): ");
                isParsed = int.TryParse(Console.ReadLine(), out n);
                Console.Write("(2).Type in k (1 < k < n): ");
                isParsed = int.TryParse(Console.ReadLine(), out k);
            } 
            while (!isParsed || n < 1 || n > 100 || k > n);

            for (int i = 1, j = 1; i <= n || j <= k; i++, j++)
            {
                // a check required if n and k are different so it doesnt keep adding up after it was supposed to stop
                if (i <= n)
                {
                    factorialN *= i;
                }
                if (j <= k)
                {
                    factorialK *= j;
                }
            }
            Console.WriteLine("n!/k1 = {0}", factorialN / factorialK);
        }
    }
}
