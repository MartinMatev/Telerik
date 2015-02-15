using System;
using System.Linq;

// Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
// Use the method from the previous exercise.
class FirstLarger
{
    static void Main()
    {
        int[] numbersArray = GetIntArray();
        CheckGivenPosition(numbersArray);
    }

    private static void CheckGivenPosition(int[] numbersArray)
    {
        int length = numbersArray.Length;

        for (int i = 1; i < length - 1; i++)
        {
            if (numbersArray[i] > numbersArray[i - 1] &&
                numbersArray[i] > numbersArray[i + 1])
            {
                PrintResult(i);
                return;
            }
        }
        PrintResult();
    }

    private static void PrintResult(int index = -1)
    {
        if (index > -1)
        {
            Console.WriteLine("The index of the element that is bigger than his neighbours is: {0}", index);
            return;
        }
        else
        {
            Console.WriteLine("There are no 2 neighbours to compare to OR there is no such element that is greater than it's neighbours!");
        }
    }

    private static int[] GetIntArray()
    {
        Console.WriteLine("Type in array of ints, separated by space or comma below");
        int[] numbersArray = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                               .Select(x => int.Parse(x))
                                               .ToArray();
        return numbersArray;
    }
}