using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the most frequent number in an array.
/*
 * Example:
            input	                              |  result
            4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 |  4 (5 times)
 */
class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter digits separated by comma or space: ");
        int[] numbersArray = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x => int.Parse(x))
                                        .ToArray();

        int arrayLength = numbersArray.Length;
        int mostFrequentNumber = 0;           
        int finalFrequencyCounter = 0;

        for (int index = 0; index < arrayLength; index++)
        {
            int currentFrequencyCounter = 1;
            for (int nextIndex = index + 1; nextIndex < arrayLength; nextIndex++)
            {
                if (numbersArray[index] == numbersArray[nextIndex])
                {
                    currentFrequencyCounter++;
                }
            }

            if (currentFrequencyCounter > finalFrequencyCounter)
            {
                finalFrequencyCounter = currentFrequencyCounter;
                mostFrequentNumber = numbersArray[index];
            }
        }
        Console.WriteLine("Most frequent number: {0} ({1} times)", mostFrequentNumber, finalFrequencyCounter);
    }
}
