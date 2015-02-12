using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the sequence of maximal sum in given array.
// Can you do it with only one loop (with single scan through the elements of the array)?
/*
 * Example:
            input	                            result
            2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
 */
class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter digits separated by comma or space: ");
        int[] numbersArray = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x => int.Parse(x))
                                        .ToArray();

        int arrayLength = numbersArray.Length;
        int maximalSum = int.MinValue;
        int currentSum = 0;
        int startingIndex = 0;
        int endingIndex = 0;
        int tempStartingIndex = 0;

        // Single loop to find the sequence with the biggest lenght
        for (int index = 0; index < arrayLength; index++)
        {
            currentSum += numbersArray[index];

            if (currentSum > maximalSum)
            {
                maximalSum = currentSum;
                startingIndex = tempStartingIndex;
                endingIndex = index;
            }

            // A necesarry check if the sum is negative, so we dont take into account
            // a negative member in the sum on the next iteration
            if (currentSum < 0)
            {
                currentSum = 0;
                // initialize the temporary starting index with the next index of the array
                tempStartingIndex = index + 1;
            }

        }
        // Display the appropriate subset with the biggest sum
        Console.WriteLine("The sequence of maximal sum in your array is: ");
        for (int i = startingIndex; i <= endingIndex; i++)
        {
            Console.Write("{0} ", numbersArray[i]);
        }
        Console.WriteLine();
    }
}