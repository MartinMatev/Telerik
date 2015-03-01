using System;

// Write a program that sorts an array of strings using the Quick sort algorithm.
class QuickSort
{
    static void Main()
    {
        int arrayLength;
        Console.Write("Enter lenght of array: ");
        if (int.TryParse(Console.ReadLine(), out arrayLength) && arrayLength > 0)
        {
            int[] intsArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter array member {0}/{1}: ", i + 1, arrayLength);
                intsArray[i] = int.Parse(Console.ReadLine());
            }
            
            int startIndex = 0;
            int endIndex = arrayLength - 1;
            // Call the recursive method with the array of nums, the first and the last index
            RecursiveQuickSort(intsArray, startIndex, endIndex);

            Console.WriteLine("Sorted array by dividing and merging subarrays below:");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("{0} ", intsArray[i]);
            }
            Console.WriteLine();
        }
    }
    public static void RecursiveQuickSort(int[] intsArray, int left, int right)
    {
        int leftPointer = left;
        int rightPointer = right;
        int middlePointer = intsArray[(left + right) / 2];

        // Loop until both left and right pointers reach the middle pointer
        while (leftPointer <= rightPointer)
        {
            // Find a larger value in the right side of the array (after the middle pointer)
            // Do that until the left pointer reaches the middle pointer
            while (intsArray[leftPointer].CompareTo(middlePointer) < 0)
            {
                leftPointer++;
            }
            // Same as above but to the other side
            while (intsArray[rightPointer].CompareTo(middlePointer) > 0)
            {
                rightPointer--;
            }

            if (leftPointer <= rightPointer)
            {
                // Swap the values to the right side if they are not on the middle pointer yet
                int swap = intsArray[leftPointer];
                intsArray[leftPointer] = intsArray[rightPointer];
                intsArray[rightPointer] = swap;

                leftPointer++;
                rightPointer--;
            }
        }
        // Recursively call itself to the array on the left side (if there is still something left there)
        if (left < rightPointer)
        {
            RecursiveQuickSort(intsArray, left, rightPointer);
        }
        // Recursively call itself on the right side (if there is still something left there)
        if (right > leftPointer)
        {
            RecursiveQuickSort(intsArray, leftPointer, right);
        }
    }
}
