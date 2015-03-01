using System;

/*
 * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
Example:

N	result
3	{1, 2, 3} 
    {1, 3, 2} 
    {2, 1, 3} 
    {2, 3, 1} 
    {3, 1, 2} 
    {3, 2, 1}
 */
class PermutationsOfSet
{
    static void Main()
    {
        int endNum;
        Console.Write("Type in `n`(the length of the set): ");
        if (int.TryParse(Console.ReadLine(), out endNum))
        {
            int[] numbersArray = new int[endNum];
            bool[] positionUsed = new bool[endNum]; // Assigns FALSE to all members by default
            int index = 0;
            int startNum = 1;
            // Call the recursive method with the numbers array, the boolean array that checks if the number has been to that position already, the starting INDEX, 
            // the starting NUM (which is 1 because the set is 1 to n), and the ending NUM (which is n)
            PermutationGeneratorRecursive(numbersArray, positionUsed, index, startNum, endNum);
        }
    }

    static void PermutationGeneratorRecursive(int[] numbersArray, bool[] positionCheck, int index, int startNum, int endNum)
    {
        // Check if the index is out of the range of the array and print the result if so
        if (index >= endNum)
        {
            // Implodes each member of the array with commas, surrounds them with {} and prints them out
            Console.WriteLine("{" + String.Join(", ", numbersArray) + "}");
        }
        else
        {
            for (int i = startNum; i <= endNum; i++)
            {
                if (positionCheck[i - startNum] == false)
                {
                    // Sets the position to true (i.e used) for the number so it doesnt repeat
                    positionCheck[i - startNum] = true;
                    numbersArray[index] = i;    // Assigns the number to the array with the appropriate index
                    PermutationGeneratorRecursive(numbersArray, positionCheck, index + 1, startNum, endNum); // calls itself with the next index
                    positionCheck[i - startNum] = false;    // After it prints out a whole line of permutations, it sets positions, 1 by 1, to false again. 
                }               
            }
        }
    }
}