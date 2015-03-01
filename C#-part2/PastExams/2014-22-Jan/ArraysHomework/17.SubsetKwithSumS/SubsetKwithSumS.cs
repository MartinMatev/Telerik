using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
// Find in the array a subset of K elements that have sum S or indicate about its absence.
class SubsetKwithSumS
{
    static void Main(string[] args)
    {
        int length;
        int wantedElementsCount;
        int sum;
        Console.Write("Enter the length of the array: ");
        bool correctLength = int.TryParse(Console.ReadLine(), out length);
        Console.Write("Enter the lenght of the subset: ");
        bool correctSubsetLength = int.TryParse(Console.ReadLine(), out wantedElementsCount);
        Console.Write("Enter the sum you want found: ");
        bool correctSum = int.TryParse(Console.ReadLine(), out sum);

        if (correctLength && correctSubsetLength && correctSum && length > 0 && wantedElementsCount > 0)
        {
            var numbersArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter array member {0}/{1}: ", i + 1, length);
                int.TryParse(Console.ReadLine(), out numbersArray[i]);
            }
            int subsetCount = (int)Math.Pow(2, length) - 1;
            int totalSubsets = 0;

            for (int i = 1; i <= subsetCount; i++)
            {
                int currentSum = 0;
                // Make a temp list, which to fill with the appropriate subsets
                List<int> elementsList = new List<int>();              

                for (int j = 0; j <= length; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;

                    if (bit == 1)
                    {
                        currentSum += numbersArray[j];
                        elementsList.Add(numbersArray[j]);
                    }
                }

                int elementsCurrentCount = elementsList.Count();
                if (currentSum == sum && elementsCurrentCount == wantedElementsCount)
                {
                    totalSubsets++;

                    // Displaying the subset with the wanted sum
                    for (int index = 0; index < elementsCurrentCount; index++)
                    {
                        if (index == elementsCurrentCount - 1)
                        {
                            Console.WriteLine("{0} = {1}", elementsList[index], sum);
                        }
                        else
                        {
                            Console.Write("{0} + ", elementsList[index]);
                        }
                    }
                }
                elementsList.Clear();
            }
            Console.WriteLine("Total number of subsets found: {0}", totalSubsets);

            // Disclaimer: If there are repeating numbers in the subset it will make combinations with EVERY repeating number. Example:
            // (subset - {2, 3, 7, 2}, number of elements we want: 2, sum to find: 5)
            // it will result in 2 + 3 = 5 AND again 3 + 2 = 5, because it treats each 2 like a separate number!
        }
    }
}
