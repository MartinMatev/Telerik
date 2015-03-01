using System;
using System.Linq;

// Write a program that finds in given array of integers a sequence of given sum S (if present).
/*
 * Example:
            array	                S	    result
            4, 3, 1, 4, 2, 5, 8 	11	    4, 2, 5
 */
class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter digits separated by comma or space: ");
        int[] numbersArray = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x => int.Parse(x))
                                        .ToArray();

        int arrayLength = numbersArray.Length; 
        int sumToFind;
        bool foundSum = false;
        Console.Write("Type in the sum to find: ");
        int.TryParse(Console.ReadLine(), out sumToFind);
        int startingIndex = 0;
        int endingIndex = 0;

        for (int index = 0; index < arrayLength; index++)
        {
            int currentSum = numbersArray[index];
            for (int nextIndex = index + 1; nextIndex < arrayLength; nextIndex++)
            {
                currentSum += numbersArray[nextIndex];

                if (currentSum == sumToFind)
                {
                    foundSum = true;
                    startingIndex = index;
                    endingIndex = nextIndex;

                    // Loop is inside so we catch and print out 
                    // all the available sequences that meet the requirements
                    for (int i = startingIndex; i <= endingIndex; i++)
                    {
                        Console.Write("{0} ", numbersArray[i]);
                    }
                    Console.Write(" = {0}\n", sumToFind);
                    break;
                }
            }
        }
        if (!foundSum)
        {
            Console.WriteLine("No subset with the required sum were found!");
        }
    }
}
