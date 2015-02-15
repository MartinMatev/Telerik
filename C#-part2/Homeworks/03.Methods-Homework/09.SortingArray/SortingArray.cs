using System;
using System.Linq;
// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.
class SortingArray
{
    static void Main(string[] args)
    {
        int startingIndex = GetIndex("starting");
        int endingIndex = GetIndex("ending");
        int[] numbersArray = GetNumberArray();
        int length = numbersArray.Length;

        int biggestNum = FindBiggestElement(numbersArray, startingIndex, endingIndex);
        int[] sortedAscending = SortAscending(numbersArray, length);
        int[] sortedDescending = SortDescending(numbersArray, length);

        PrintResult(biggestNum, sortedAscending, sortedDescending);
    }

    private static void PrintResult(int biggestNum, int[] sortedAscending, int[] sortedDescending)
    {
        Console.WriteLine("\nBiggest number in the given range is: {0}", biggestNum);
        Console.WriteLine("Array in ascending order: {0}", String.Join(" ", sortedAscending));
        Console.WriteLine("Array in descending order: {0}", String.Join(" ", sortedDescending));
    }

    private static int[] SortDescending(int[] numbersArray, int length)
    {
        int[] descendingArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            descendingArray[i] = FindBiggestElement(numbersArray, i, length - 1, i);
        }
        return descendingArray;
    }

    private static int[] SortAscending(int[] numbersArray, int length)
    {
        int[] ascendingArray = new int[length];
        for (int i = length - 1; i >= 0; i--)
        {
            ascendingArray[i] = FindBiggestElement(numbersArray, 0, i, i);
        }
        return ascendingArray;
    }

    private static int FindBiggestElement(int[] numbersArray, int start, int end, int indexToSwap = 0)
    {
        if (start < 0 || start > numbersArray.Length ||
            end < 0 || end > numbersArray.Length)
        {
            throw new IndexOutOfRangeException();
        }

        int biggestNumber = int.MinValue;
        int biggestNumIndex = 0;
        for (int i = start; i <= end; i++)
        {
            if (numbersArray[i] > biggestNumber)
            {
                biggestNumber = numbersArray[i];
                biggestNumIndex = i;
            }
        }
        
        return SwapIndexes(numbersArray, biggestNumIndex, indexToSwap);
    }

    private static int SwapIndexes(int[] numbersArray, int biggestNumIndex, int indexToSwap)
    {
        int valueHolder = numbersArray[indexToSwap];
        numbersArray[indexToSwap] = numbersArray[biggestNumIndex];
        numbersArray[biggestNumIndex] = valueHolder;

        return numbersArray[indexToSwap];
    }

    private static int GetIndex(string p)
    {
        Console.Write("Enter the {0} index: ", p);
        return int.Parse(Console.ReadLine());
    }

    private static int[] GetNumberArray()
    {
        Console.WriteLine("Type in array of integers, separated by space or comma below:");
        return Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(x => int.Parse(x))
                                 .ToArray();
    }
}
