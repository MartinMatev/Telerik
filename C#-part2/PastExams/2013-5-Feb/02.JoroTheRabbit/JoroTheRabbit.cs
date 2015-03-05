using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class JoroTheRabbit
{
    static void Main()
    {
        int[] terrainNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                 .Select(int.Parse)
                                                 .ToArray();
        int maxRange = int.MinValue;
        // A loop for every number of the terrain
        for (int startIndex = 0; startIndex < terrainNumbers.Length; startIndex++)
        {
            for (int step = 1; step < terrainNumbers.Length; step++)
            {
                int currentRange = 1;
                int currentIndex = startIndex;
                int nextIndex = (currentIndex + step) % terrainNumbers.Length;

                while (terrainNumbers[nextIndex] > terrainNumbers[currentIndex])
                {
                    currentRange++;
                    currentIndex = nextIndex;
                    nextIndex = (currentIndex + step) % terrainNumbers.Length;
                }

                if (maxRange < currentRange)
                {
                    maxRange = currentRange;
                }
            }
        }

        Console.WriteLine(maxRange);
    }
}
