using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
namespace _12.RandomizeTheNumbers
{
    class RandomizeTheNumbers
    {
        static void Main(string[] args)
        {
            int n;
            Random rand = new Random();
            Console.Write("Type in n: ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = i + 1;
                }
                // OrderBy returns a sequence which is a sorted copy of the array.
                // Gives a unique, random number to each element, then ordering the elements according to that number.
                int[] randomArr = arr.OrderBy(x => rand.Next()).ToArray();
                foreach (int digit in randomArr)
                {
                    Console.Write("{0} ", digit);
                }
            }          
        }
    }
}
