using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that finds the maximal increasing sequence in an array.
/*
 * Example:
        input	                result
        3, 2, 3, 4, 2, 2, 4	    2, 3, 4
 */
class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter digits separated by comma or space: ");
        int[] sequenceArray = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x => int.Parse(x))
                                        .ToArray();

        int arrayLength = sequenceArray.Length;
        int maxSequence = int.MinValue;
        int startingSequenceNumber = 0;
        List<int> biggestSequence = new List<int>();
        List<int> temporarySequence = new List<int>();

        // Loop through every array element, and compare him with the rest of the elements
        for (int index = 0; index < arrayLength; index++)
        {
            int sequenceCounter = 0;
            int currentSequence = 0;
            temporarySequence.Clear();

            for (int nextIndex = index + 1; nextIndex < arrayLength; nextIndex++)
            {
                // Checks if the next number is BIGGER than the previous (Bigger as in not + 1, but bigger in general (+ 2, + 5 etc.))
                if (sequenceArray[index + sequenceCounter] < sequenceArray[nextIndex])
                {
                    // If so, current sequence counter goes up by 1 and the element is added to the temporary sequence list
                    currentSequence++;
                    temporarySequence.Add(sequenceArray[nextIndex]);
                }
                else
                {
                    break;
                }
                // the sequence counter goes up by 1 after every turn, so we add it to the current index and take the next element
                sequenceCounter++;
            }
            // If the current sequence is equal or greater, initialize the maxSequence with its value, 
            //initialize the "startingSequenceNumber" with first element of the sequence, and move the sequence MEMBERS from the temp list, to the actual one.                 
            if (currentSequence >= maxSequence)
            {
                maxSequence = currentSequence;
                startingSequenceNumber = sequenceArray[index];
                biggestSequence = temporarySequence.ToList();
            }
        }
        Console.WriteLine("The maximal increasing sequence in your array is: ");
        Console.Write("{0} ", startingSequenceNumber);
        foreach (int number in biggestSequence)
        {
            Console.Write("{0} ", number);
        }
    }
}
