using System;

// You are given an array of strings. Write a method that sorts the array by the length of its 
// elements (the number of characters composing them)
class SortByStringLength
{
    static void Main()
    {
        string[] input = GetElements();
        SortArray(input);       
    }

    private static void SortArray(string[] stringArray)
    {
        int length = stringArray.Length;
        for (int currentIndex = 0; currentIndex < length - 1; currentIndex++)
        {
            int smallestStrIndex = currentIndex;
            for (int nextIndex = currentIndex + 1; nextIndex < length; nextIndex++)
            {
                if (stringArray[nextIndex].Length < stringArray[currentIndex].Length)
                {
                    smallestStrIndex = nextIndex;
                }
            }
            // Swaps the value of the string at current index with the lesser in length value at smallestStrIndex index.
            string temp = stringArray[currentIndex];
            stringArray[currentIndex] = stringArray[smallestStrIndex];
            stringArray[smallestStrIndex] = temp;

        }
        DisplaySortedArray(stringArray);
    }

    private static void DisplaySortedArray(string[] array)
    {

        string result = String.Join(", ", array);
        Console.WriteLine("Sorted array: {0}", result);
    }

    private static string[] GetElements()
    {
        Console.WriteLine("Enter strings, separated by space: ");
        string[] strArray = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        return strArray;
    }
}
