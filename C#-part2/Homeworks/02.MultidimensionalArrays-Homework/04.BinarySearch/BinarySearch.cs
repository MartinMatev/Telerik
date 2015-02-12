using System;

// Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
class BinarySearch
{
    static void Main()
    {
        int arrayLenght = GetData("length");
        int[] numbersArray = GetArray(arrayLenght);
        int number = GetData("number K");
        int result = FindLargestNumber(numbersArray, number);
        Console.WriteLine("The largest number, which is <= {0} is: {1}", number, result);
    }

    private static int FindLargestNumber(int[] numbersArray, int numberToFind)
    {
        Array.Sort(numbersArray);
        int index = Array.BinarySearch(numbersArray, numberToFind);
        int result = 0;
        // If the number is less than the smallest value in your array
        if (numberToFind < numbersArray[0])
        {
            Console.WriteLine("The number you want found, is LESS than the smallest value of the array");
        }
        // If the number isn't present in the array, it will return a negative value for index.
        // The negative index is of the next element that is larger than the number we are searching for
        // So we invert it and substract it by 1 , to get the index of the closest smaller number
        if (index < 0)
        {
            index = ~index - 1;
        }
        if (index >= 0)
        {
            result = numbersArray[index];
        }
        return result;
    }

    private static int[] GetArray(int arrayLenght)
    {
        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {          
            Console.Write("Type in number {0}/{1}: ", i + 1, arrayLenght);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    private static int GetData(string input)
    {
        Console.Write("Enter the {0}: ", input);
        return int.Parse(Console.ReadLine());
    }
}