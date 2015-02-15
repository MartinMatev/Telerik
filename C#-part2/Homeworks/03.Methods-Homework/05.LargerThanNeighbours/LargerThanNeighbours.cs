using System;
using System.Linq;

// Write a method that checks if the element at given position in given array of integers 
// is larger than its two neighbours (when such exist).
class LargerThanNeighbours
{
    static void Main()
    {
        uint elementPosition = GetElementPosition();
        int[] numbersArray = GetIntArray();
        CheckGivenPosition(elementPosition, numbersArray);
    }

    private static void CheckGivenPosition(uint elementPosition, int[] numbersArray)
    {
        bool isBigger = false;
        int length = numbersArray.Length;

        if (length > 1 && numbersArray[elementPosition] == numbersArray[0])
        {
            isBigger = numbersArray[elementPosition] > numbersArray[elementPosition + 1];
        }
        else if (length > 1 && numbersArray[elementPosition] == numbersArray[numbersArray.Length - 1])
        {
            isBigger = numbersArray[elementPosition] > numbersArray[elementPosition - 1];
        }
        else if (length > 1 && numbersArray[elementPosition] > numbersArray[elementPosition + 1] &&
            numbersArray[elementPosition] > numbersArray[elementPosition - 1])
        {
            isBigger = true;
        }
        PrintResult(isBigger);
    }

    private static void PrintResult(bool isBigger)
    {
        Console.WriteLine("It is {0} that the element is bigger than his neighbours (or neighbour if its only one).", isBigger);
    }

    private static int[] GetIntArray()
    {
        Console.WriteLine("Type in array of ints, separated by space or comma below");
        int[] numbersArray = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                               .Select(x => int.Parse(x))
                                               .ToArray();
        return numbersArray;
    }

    private static uint GetElementPosition()
    {
        Console.Write("Type in the position of the element: ");
        return uint.Parse(Console.ReadLine());
    }
}