using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TheyAreGreen
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] letters = new int[N];

        for (int i = 0; i < N; i++)
        {
            letters[i] = (int)char.Parse(Console.ReadLine());
        }
        Array.Sort(letters);
        int counter = 0;
        if (isValid(letters))
        {
            counter++;
        }

        while (NextPermutation(letters))
        {
            if (isValid(letters))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }

    private static bool isValid(int[] letters)
    {
        int previous = letters[0];
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == previous)
            {
                return false;
            }
            previous = letters[i];
        }
        return true;
    }

    static bool NextPermutation(int[] numList)
    {
        var largestIndex = -1;
        for (int i = numList.Length - 2; i >= 0; i--)
        {
            if (numList[i] < numList[i + 1])
            {
                largestIndex = i;
                break;
            }
        }

        if (largestIndex < 0) return false;

        var largestIndex2 = -1;
        for (int i = numList.Length - 1; i >= 0; i--)
        {
            if (numList[largestIndex] < numList[i])
            {
                largestIndex2 = i;
                break;
            }
        }

        var tmp = numList[largestIndex];
        numList[largestIndex] = numList[largestIndex2];
        numList[largestIndex2] = tmp;

        for (int i = largestIndex + 1, j = numList.Length - 1; i < j; i++, j--)
        {
            tmp = numList[i];
            numList[i] = numList[j];
            numList[j] = tmp;
        }

        return true;
    }
}