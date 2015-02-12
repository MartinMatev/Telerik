using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the index of given element 
// in a sorted array of integers by using the Binary search algorithm
class BinarySearch
{
    static void Main()
    {
        int arrayLength;
        Console.Write("Type in array length: ");
        if (int.TryParse(Console.ReadLine(), out arrayLength) && arrayLength > 0)
        {
            int[] numbersArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Type in array member {0}/{1}: ", i + 1, arrayLength);
                int.TryParse(Console.ReadLine(), out numbersArray[i]);
            }

            Console.Write("Enter the element, which index you want found: ");
            int valueToFind;
            if (int.TryParse(Console.ReadLine(), out valueToFind))
            {
                Array.Sort(numbersArray);
                Console.WriteLine("The sorted array looks like this: ");
                for (int i = 0; i < arrayLength; i++)
                {
                    Console.Write("{0} ", numbersArray[i]);
                }
                Console.WriteLine();

                // Version 1: self implemented Binary Search
                int firstElement = 0;
                int lastElement = arrayLength - 1;
                while (firstElement <= lastElement)
                {
                    // make the midPoint var the...middle index of the array
                    int midPoint = (firstElement + lastElement) / 2;
                    // If the value we are searching for is bigger than the number at the middle point
                    if (numbersArray[midPoint] < valueToFind)
                    {
                        // make the starting point of the next search the index after the middle one
                        firstElement = midPoint + 1;
                    }
                    // else if the value is less
                    else if (numbersArray[midPoint] > valueToFind)
                    {
                        // make the ending point the index before the middle one
                        lastElement = midPoint - 1;
                    }
                    else
                    {
                        // We have found the idnex
                        Console.WriteLine("The index of the element {0} is : {1}", valueToFind, midPoint);
                        return;
                    }
                }
                Console.WriteLine("The number, which index you want found doesn't exist in the array!");

                // Version 2: using the exsiting BinarySearch function
                //int indexToFind = Array.BinarySearch(numbersArray, valueToFind);
                //Console.WriteLine("The index of the element {0} is : {1}", valueToFind, indexToFind);
            }
        }
    }
}
