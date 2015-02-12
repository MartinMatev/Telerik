using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum
class MaximalKsum
{
    static void Main()
    {
        int arrayLenght;
        int numberOfElements;
        Console.Write("Type in the lenght of the array: ");
        bool validLenght = int.TryParse(Console.ReadLine(), out arrayLenght);
        Console.Write("Type in the number of elements: ");
        bool validNumbers = int.TryParse(Console.ReadLine(), out numberOfElements);

        if (validLenght && validNumbers && arrayLenght > 0 && numberOfElements >= 0)
        {
            int[] numbersArray = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("Type in array member {0}/{1}: ", i + 1, arrayLenght);
                int.TryParse(Console.ReadLine(), out numbersArray[i]);
            }

            // Sort the array for the least number of itterations in the cycle below
            Array.Sort(numbersArray);

            int maximalSum = 0;
            // Loop, starting from the last element (which is the biggest one in value after the sort)
            try
            {
                Console.Write("The biggest members of the array are: ");
                for (int i = numbersArray.Length - 1; i >= arrayLenght - numberOfElements; i--)
                {
                    maximalSum += numbersArray[i];
                    Console.Write("{0} ", numbersArray[i]);
                }
                Console.WriteLine("\nTheir sum is: {0}", maximalSum);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nAwkward. The array lenght cannot be less than the number of digits you want summed.");
                Console.WriteLine("Please insert coin to continue...");
            }
        }
    }
}
