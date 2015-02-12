using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads two numbers N and K and generates all the combinations 
 * of K distinct elements from the set [1..N].
Example:

N	K	result
5	2	{1, 2} 
        {1, 3} 
        {1, 4} 
        {1, 5} 
        {2, 3} 
        {2, 4} 
        {2, 5} 
        {3, 4} 
        {3, 5} 
        {4, 5}
 */

class CombinationsOfSet
{
    static void Main()
    {
        Console.Write("Enter `n` (the set length (1 to n)): ");
        int endNum = int.Parse(Console.ReadLine());
        Console.Write("Enter `k` (the number of distinct elements): ");
        int length = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[length];
        CombinationGeneratorRecursive(numbersArray, 0, 1, endNum);
    }

    static void CombinationGeneratorRecursive(int[] numbersArray, int index, int startNum, int endNum)
    {
        if (index >= numbersArray.Length)
        {
            Console.WriteLine("{" + String.Join(", ", numbersArray) + "}");
        }
        else
        {
            for (int i = startNum; i <= endNum; i++)
            {
                numbersArray[index] = i;
                // Call itself recursively with the NEXT index, up the next number `i` by 1 to AVOID repetitions of numbers, and send the end num so it knows when to stop 
                CombinationGeneratorRecursive(numbersArray, index + 1, i + 1, endNum);
            }
        }
    }
}