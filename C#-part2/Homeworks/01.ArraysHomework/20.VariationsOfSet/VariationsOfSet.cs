using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads two numbers N and K and generates 
 * all the variations of K elements from the set [1..N].
Example:

N	K	result
3	2	{1, 1} 
        {1, 2} 
        {1, 3} 
        {2, 1} 
        {2, 2} 
        {2, 3} 
        {3, 1} 
        {3, 2} 
        {3, 3}
 */
class VariationsOfSet
{
    static void Main()
    {
        Console.Write("Enter `n` (the set length (1 to n)): ");
        int endNum = int.Parse(Console.ReadLine());
        Console.Write("Enter `k` (the number of elements): ");
        int length = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[length];
        int index = 0;
        int startNum = 1;
        VariationGeneratorRecursive(numbersArray, index, startNum, endNum);
    }

    static void VariationGeneratorRecursive(int[] numbersArray, int index, int startNum, int endNum)
    {
        // Check if the index is out of the range of the array and print the result if so
        if (index >= numbersArray.Length)
        {
            // Print combination by adding { } and IMPLODING (known as String.Join in C# apperantly...) inbetween them every array member with a comma
            Console.WriteLine("{" + String.Join(", ", numbersArray) + "}");
        }
        else
        {
            for (int i = startNum; i <= endNum; i++)
            {
                numbersArray[index] = i;
                // Call itself recursively with the NEXT index
                VariationGeneratorRecursive(numbersArray, index + 1, startNum, endNum);
            }
        }
    }
}
