using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GreedyDwarf
{
    static void Main()
    {
        int[] valley = ReadArray();
        int numberOfPatterns = int.Parse(Console.ReadLine());
        int maxSum = int.MinValue;

        for (int i = 0; i < numberOfPatterns; i++)
        {
            int[] pattern = ReadArray();
            int currentSum = WorkWithPattern(valley, pattern);

            if (maxSum < currentSum)
            {
                maxSum = currentSum;
            }
        }

        Console.WriteLine(maxSum);
    }

    private static int WorkWithPattern(int[] valley, int[] pattern)
    {
        bool[] isVisited = new bool[valley.Length];
        int currentIndex = 0;
        int currentSum = valley[currentIndex];
        isVisited[currentIndex] = true;

        for (int j = 0; true ; j++)
        {
            if (j > pattern.Length - 1)
            {
                j -= pattern.Length;
            }


            int nextStep = pattern[j];
            currentIndex += nextStep;

            if (currentIndex < 0 || currentIndex > valley.Length -1 || isVisited[currentIndex])
            {
                break;
            }

            currentSum += valley[currentIndex];
            isVisited[currentIndex] = true;
        }
        return currentSum;
    }

    private static int[] ReadArray()
    {
        return Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
    }
}
