using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
 */ 
namespace _3.MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type in number of digits: ");
                int digitCount = int.Parse(Console.ReadLine());
                int[] numberSequence = new int[digitCount];
                for (int i = 0; i < digitCount; i++)
                {
                    Console.Write("Type in number {0} / ({1}) of the sequence: ", i + 1, digitCount);
                    numberSequence[i] = int.Parse(Console.ReadLine());
                }

                /* Version 1 (using  integrated functions)
                 * 
                Console.WriteLine("Min: {0}", numberSequence.Min());
                Console.WriteLine("Max: {0}", numberSequence.Max());
                Console.WriteLine("Sum: {0}", numberSequence.Sum());
                Console.WriteLine("Average: {0:F2}", numbers.Average());
                 */

                //Version 2 (using loops)
                int min = numberSequence[0];
                int max = numberSequence[0];
                int sum = 0;
                double average;
                for (int i = 0; i < numberSequence.Length; i++)
                {
                    sum += numberSequence[i];
                    if (numberSequence[i] < min)
                    {
                        min = numberSequence[i];
                    }
                    if (numberSequence[i] > max)
                    {
                        max = numberSequence[i];
                    }
                }
                average = (double)sum / numberSequence.Length;
                Console.WriteLine("Min: {0}", min);
                Console.WriteLine("Max: {0}", max);
                Console.WriteLine("Sum: {0}", sum);
                Console.WriteLine("Average: {0:F2}", average);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong data format!");
            }
        }
    }
}
