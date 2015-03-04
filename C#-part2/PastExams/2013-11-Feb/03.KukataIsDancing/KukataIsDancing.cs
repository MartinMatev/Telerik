using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class KukataIsDancing
{
    static void Main()
    {
        // Read the input
        int numberOfDances = int.Parse(Console.ReadLine());
        string[,] floor = {
                              {"RED", "BLUE", "RED"},
                              {"BLUE", "GREEN", "BLUE"},
                              {"RED", "BLUE", "RED"}
                          };

        int[][] directions = {
                                 new int[]{0, 1},   // right
                                 new int[]{-1, 0},  // up
                                 new int[]{0, -1},  // left
                                 new int[]{1, 0}    // down
                             };

        for (int i = 0; i < numberOfDances; i++)
        {
            string dance = Console.ReadLine();
            int[] pos = { 1, 1 };   //starting position
            int dirIndex = 0;
            int[] currentDir = directions[dirIndex];

            foreach (char step in dance)
            {
                switch (step)
                {
                    case 'W':
                        pos = Walk(pos, currentDir);

                        // Rotate the dance flor
                        for (int j = 0; j <= 1; j++)
                        {
                            if (pos[j] >= floor.GetLength(j))
                            {
                                pos[j] = 0;
                            }
                            else if (pos[j] < 0)
                            {
                                pos[j] = floor.GetLength(j) - 1;
                            }
                        }
                        break;
                    case 'R':
                        dirIndex = TurnRight(directions, dirIndex);
                        currentDir = directions[dirIndex]; // assign new direction
                        break;
                    case 'L':
                        dirIndex = TurnLeft(directions, dirIndex);
                        currentDir = directions[dirIndex]; // assign new direction
                        break;
                }
            }

            int currentRow = pos[0];
            int currentCol = pos[1];
            string result = floor[currentRow, currentCol];

            Console.WriteLine(result);
        }
    }

    private static int[] Walk(int[] pos, int[] currentDir)
    {
        for (int i = 0; i < pos.GetLength(0); i++)
        {
            pos[i] += currentDir[i];
        }
        return pos;
    }

    private static int TurnLeft(int[][] directions, int dirIndex)
    {
        dirIndex += 1;
        if (dirIndex >= directions.GetLength(0))
        {
            dirIndex = 0;
        }
        return dirIndex;
    }

    private static int TurnRight(int[][] directions, int dirIndex)
    {
        dirIndex -= 1;
        if (dirIndex < 0)
        {
            dirIndex = directions.GetLength(0) - 1;
        }
        return dirIndex;
    }
}
