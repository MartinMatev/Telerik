using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Write a program that reads an array of integers and removes from it a minimal number of elements in such a way
 * that the remaining array is sorted in increasing order.
 * Print the remaining sorted array.
Example:

input	                        result
6, 1, 4, 3, 0, 3, 6, 4, 5	    1, 3, 3, 4, 5
 */
class RemoveElements
{
    static void Main()
    {
        Console.Write("Enter digits separated by comma or space: ");
        int[] numbersArray = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x => int.Parse(x))
                                        .ToArray();

        int arrayLength = numbersArray.Length;
        int subsetCount = (int)Math.Pow(2, arrayLength) - 1;
        List<int> subsetList = new List<int>();
        // Make a temp list, which to fill with the appropriate subsets
        List<int> tempList = new List<int>();

        for (int i = 1; i <= subsetCount; i++)
        {
            for (int j = 0; j <= arrayLength; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;

                if (bit == 1)
                {
                    tempList.Add(numbersArray[j]);
                }
            }

            int elementsCurrentCount = subsetList.Count();
            int tempListCount = tempList.Count();
            // Check if the elements of the list are in increasing order, and their count is bigger than the last sublist
            if (IsIncreasing(tempList) && tempListCount > elementsCurrentCount)
            {
                subsetList.Clear();
                subsetList = tempList.ToList();
            }

            tempList.Clear();
        }

        // Displaying the biggest subset
        foreach (var digit in subsetList)
        {
            Console.Write("{0} ", digit);
        }
        Console.WriteLine();
    }
    // A method for looping the digits in the current sublist and 
    //returning TRUE if they are in increasing order, returns FALSE otherwise.
    static bool IsIncreasing(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
            if (numbers[i] > numbers[i + 1])
            {
                return false;
            }
        return true;
    }
}
