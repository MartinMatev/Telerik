using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that sorts an array of integers using the Merge sort algorithm.
class MergeSort
{
    static int maxLenght = 0;
    static void Main()
    {
        int arrayLength;
        Console.Write("Enter lenght of array: ");
        if (int.TryParse(Console.ReadLine(), out arrayLength) && arrayLength > 0)
        {
            maxLenght = arrayLength * 2;
            int[] numbersArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter array member {0}/{1}: ", i + 1, arrayLength);
                int.TryParse(Console.ReadLine(), out numbersArray[i]);
            }
            int startIndex = 0;
            int endIndex = arrayLength - 1;
            // Call the recursive method with the array of nums, the first and the last index
            RecursiveMergeSort(numbersArray, startIndex, endIndex);

            Console.WriteLine("Sorted array by dividing and merging subarrays below:");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("{0} ", numbersArray[i]);
            }
        }
    }
    // A recursive method that calls itself afte the first call from the Main method
    public static void RecursiveMergeSort(int[] numbers, int left, int right)
    {
        int midIndex;

        if (right > left)
        {
            midIndex = (right + left) / 2;
            RecursiveMergeSort(numbers, left, midIndex);
            RecursiveMergeSort(numbers, (midIndex + 1), right);

            Merge(numbers, left, (midIndex + 1), right);
        }
    }
    public static void Merge(int[] numbers, int left, int mid, int right)
    {
        int[] tempArray = new int[maxLenght];
        int leftEnd;
        int elementsCount;
        int tempIndex;

        leftEnd = (mid - 1);    //the last index before the middle one
        tempIndex = left;
        elementsCount = (right - left + 1); // total elements count

        // a loop that continues until we reach the middle from 
        //the left and right part of the array        
        while ((left <= leftEnd) && (mid <= right))
        { 
            if (numbers[left] <= numbers[mid])
            {
                tempArray[tempIndex++] = numbers[left++];
            }
            else
            {
                tempArray[tempIndex++] = numbers[mid++];
            }
        }

        while (left <= leftEnd)
        {
            tempArray[tempIndex++] = numbers[left++];
        }

        while (mid <= right)
        {
            tempArray[tempIndex++] = numbers[mid++];
        }

        for (int i = 0; i < elementsCount; i++)
        {
            numbers[right] = tempArray[right];
            right--;
        }
    }
}
