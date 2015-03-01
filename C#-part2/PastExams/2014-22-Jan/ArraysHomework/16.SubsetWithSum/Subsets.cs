using System;
using System.Linq;

// We are given an array of integers and a number S.
// Write a program to find if there exists a subset of the elements of the array that has a sum S.
/*
 * Example:

input array	                S	    result
2, 1, 2, 4, 3, 5, 2, 6	    14	    yes
 */
class Subsets
{
    static void Main()
    {
        Console.Write("Enter digits separated by comma or space: ");
        int[] numbersArray = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x => int.Parse(x))
                                        .ToArray();

        int arrayLength = numbersArray.Length;

        // Loop through 1 to the array length (the binary representation of these numbers cover ALL possible combinations - 2^array's lenght - 1)
        int subsetCount = (int)Math.Pow(2, arrayLength) - 1;
        int sum;
        int totalSubsets = 0;
        Console.Write("Enter the sum you want found: ");
        if (int.TryParse(Console.ReadLine(), out sum))
        {
            for (int i = 1; i <= subsetCount; i++)
            {
                int currentSum = 0;
                for (int j = 0; j <= arrayLength; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    // If the bit from the `i & mask` is 1, add the number at that position to the current sum
                    if (bit == 1)
                    {
                        currentSum += numbersArray[j];
                    }
                }

                if (currentSum == sum)
                {
                    totalSubsets++;                       
                }
            }
            if (totalSubsets >= 1)
            {
                Console.WriteLine("\nyes");
                Console.WriteLine("Total subsets found: {0}", totalSubsets);
            }
            else
            {
                Console.WriteLine("No subsets with the wanted sum were found in the array.");
            }
        }
    }
}
