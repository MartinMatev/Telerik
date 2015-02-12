using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * In combinatorics, the number of ways to choose k different members out of a group of n different elements 
 * (also known as the number of combinations) is calculated by a formula 
 * For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
 * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
 */ 
namespace _7.CalculateThree
{
    class CalculationsThree
    {
        static void Main(string[] args)
        {
            int k;
            int n;
            bool isParsed = false;
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger nMinusKFactorial = 1;

            do
            {
                Console.Write("(1).Type in n (1 < n < 100): ");
                isParsed = int.TryParse(Console.ReadLine(), out n);
                Console.Write("(2).Type in k (1 < k < n): ");
                isParsed = int.TryParse(Console.ReadLine(), out k);
            }
            while (!isParsed || n < 1 || n > 100 || k > n);

            int nMinusK = n - k;
            for (int i = 1, j = 1; i <= n || j <= k; i++, j++)
            {
                if (i <= n)
                {
                    factorialN *= i;
                }
                if (j <= k)
                {
                    factorialK *= j;
                }
                if (i < n || j < k)
                {
                    continue;
                }
                for (int l = 1; l <= nMinusK; l++)
                {
                    nMinusKFactorial *= l;
                }
            }
            BigInteger equation = factorialN / (factorialK * nMinusKFactorial);
            Console.WriteLine("The answer to the equation is : {0}", equation);
        }
    }
}
