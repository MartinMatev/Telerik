using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class TwoGirlsOnePath
{
    static void Main()
    {
        long[] cellFlowers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        int cellFieldLength = cellFlowers.Length;

        BigInteger mollyFlowers = 0;       
        long nextMollyIndex = 0;

        BigInteger dollyFlowers = 0;      
        long nextDollyIndex = cellFieldLength - 1;

        string winner = string.Empty;

        for (int i = 0; true; i++)
        {

            if (cellFlowers[nextMollyIndex] == 0 || cellFlowers[nextDollyIndex] == 0)
            {
                if (cellFlowers[nextMollyIndex] == 0 && cellFlowers[nextDollyIndex] == 0)
                {
                    winner = "Draw";
                }
                else if (cellFlowers[nextMollyIndex] == 0)
                {
                    winner = "Dolly";
                }
                else if (cellFlowers[nextDollyIndex] == 0)
                {
                    winner = "Molly";
                }

                mollyFlowers += cellFlowers[nextMollyIndex];
                dollyFlowers += cellFlowers[nextDollyIndex];
                break;
            }

            BigInteger currentMollyFlowers = cellFlowers[nextMollyIndex];
            BigInteger currentDollyFlowers = cellFlowers[nextDollyIndex];



            // if the game doesn't end do the following:
            if (nextMollyIndex == nextDollyIndex)
            {
                // If the flowers in the cell are even
                if (cellFlowers[nextMollyIndex] % 2 == 0)
                {
                    mollyFlowers += cellFlowers[nextMollyIndex] / 2;
                    currentMollyFlowers = cellFlowers[nextMollyIndex];

                    dollyFlowers += cellFlowers[nextDollyIndex] / 2;
                    currentDollyFlowers = cellFlowers[nextDollyIndex];

                    cellFlowers[nextMollyIndex] = 0;
                }
                else
                {
                    mollyFlowers += cellFlowers[nextMollyIndex] / 2;
                    currentMollyFlowers = cellFlowers[nextMollyIndex];

                    dollyFlowers += cellFlowers[nextDollyIndex] / 2;
                    currentDollyFlowers = cellFlowers[nextDollyIndex];

                    cellFlowers[nextMollyIndex] = 1;    // Leave 1 flower at the current location if odd flowers
                }
            }
            else
            {
                mollyFlowers += cellFlowers[nextMollyIndex];
                currentMollyFlowers = cellFlowers[nextMollyIndex];
                cellFlowers[nextMollyIndex] = 0;

                dollyFlowers += cellFlowers[nextDollyIndex];
                currentDollyFlowers = cellFlowers[nextDollyIndex];
                cellFlowers[nextDollyIndex] = 0;
            }

            nextMollyIndex = (long)(nextMollyIndex + currentMollyFlowers) % cellFieldLength;
            nextDollyIndex = (long)(nextDollyIndex - currentDollyFlowers) % cellFieldLength;
            // check if Dolly index is less than zero, because we are going backwards
            if (nextDollyIndex < 0)
            {
                nextDollyIndex += cellFieldLength;
            }
        }

        Console.WriteLine(winner);
        Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
    }
}
