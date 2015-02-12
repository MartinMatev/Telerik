using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads from the console a positive integer number n (1 = n = 20) 
// and prints a matrix like in the examples below. Use two nested loops.
namespace _9.MatirxOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n;
            bool isParsed = false;

            do
            {
                Console.Write("(1).Type in n (1 < n < 20): ");
                isParsed = int.TryParse(Console.ReadLine(), out n);
            }
            while (!isParsed || n < 1 || n > 20);

            int [,] arr = new int[n,n];
            Console.WriteLine("matrix");
            for (int row = 1; row <= arr.GetLength(0); row++)
            {
                for (int col = 1; col <= arr.GetLength(0); col++)
                {
                    Console.Write("{0} ", col + row - 1);
                }
                Console.WriteLine();
            }
        }
    }
}
