using System;
using System.Linq;
/*
 * You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum.
 * Example:
 * 
 * input	            output
 * 43 68 9 23 318	    461
 */
class SumIntegers
{
    static void Main()
    {
        string[] input = GetNumbers();
        CalculateSum(input);
    }

    private static void CalculateSum(string[] numbers)
    {
        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += long.Parse((numbers[i]));
        }
        PrintResult(sum);
    }

    private static void PrintResult(long sum)
    {
        Console.WriteLine("The sum of the integers is: {0}", sum);
    }

    private static string[] GetNumbers()
    {
        Console.WriteLine("Enter the sequence of integers, separated by space:");
        Console.Write(">>");
        return Console.ReadLine().Split(new char[]{' ', ',', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();
                                
    }
}
