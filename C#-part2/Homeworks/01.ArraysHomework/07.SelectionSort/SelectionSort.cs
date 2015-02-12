using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
// find the smallest from the rest, move it at the second position, etc.
class SelectionSort
{
    static void Main()
    {
        int arrayLenght;
        Console.Write("Enter the lenght of the array: ");
        if (int.TryParse(Console.ReadLine(), out arrayLenght) && arrayLenght > 0)
        {
            int[] numbersArray = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("Enter element number {0}/{1}: ", i + 1, arrayLenght);
                int.TryParse(Console.ReadLine(), out numbersArray[i]);
            }

            // Initialize the first array digit as the min value
            for (int index = 0; index < arrayLenght; index++)
            {
                bool swapCheck = false;
                int minDigitIndex = index;
                for (int nextIndex = index + 1; nextIndex < arrayLenght; nextIndex++)
                {
                    if (numbersArray[nextIndex] < numbersArray[minDigitIndex])
                    {
                        minDigitIndex = nextIndex;
                        swapCheck = true;
                    }
                }
                if (swapCheck)
                {
                    // Call the Swap method, with the array and the 2 positions which values to swap
                    SwapArrayValues(numbersArray, index, minDigitIndex);
                }
            }
            Console.WriteLine("The sorted array:");
            foreach (var number in numbersArray)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
    static void SwapArrayValues(int[] array, int positionOne, int positionTwo)
    {
        int temp = array[positionOne];
        array[positionOne] = array[positionTwo];
        array[positionTwo] = temp;
    }
}
