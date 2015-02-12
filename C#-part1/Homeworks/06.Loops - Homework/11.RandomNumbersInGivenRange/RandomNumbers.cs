using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].
namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            int n;
            int min;
            int max;
            int number = 0;
            bool isParsed;
            Random rand = new Random();
            do 
            {              
                Console.Write("Enter n: ");
                isParsed = int.TryParse(Console.ReadLine(), out n);
                Console.Write("Enter min: ");
                isParsed = int.TryParse(Console.ReadLine(), out min);
                Console.Write("Enter max: ");
                isParsed = int.TryParse(Console.ReadLine(), out max);
            }
            while (max < min || !isParsed);

            for (int i = 0; i < n; i++)
            {
                // min value is inclusive and max is exclusive, so we add 1 to max so it includes it too
                number = rand.Next(min, max + 1);
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
