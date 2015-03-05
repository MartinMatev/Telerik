using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Laser
{
    static void Main()
    {
        string[] line = Console.ReadLine().Split(' ');
        int cubeWidth = int.Parse(line[0]);
        int cubeHeight = int.Parse(line[1]);
        int cubeDepth = int.Parse(line[2]);

        bool[, ,] cube = new bool[cubeWidth, cubeHeight, cubeDepth];

        MarkBurnt(cubeWidth, cubeHeight, cubeDepth, cube);

        line = Console.ReadLine().Split(' ');   // - 1 because it starts form 1,1,1 and not 0,0,0
        int nextWidth = int.Parse(line[0]) - 1;
        int nextHeight = int.Parse(line[1]) - 1;
        int nextDepth = int.Parse(line[2]) - 1;

        line = Console.ReadLine().Split(' ');
        int dirWidth = int.Parse(line[0]);
        int dirHeight = int.Parse(line[1]);
        int dirDepth = int.Parse(line[2]);

        // shoot laser
        int currentWidth, currentHeight, currentDepth;
        while (true)
        {
            // go to the next position
            currentWidth = nextWidth;
            currentHeight = nextHeight;
            currentDepth = nextDepth;

            // burn the current position
            cube[currentWidth, currentHeight, currentDepth] = true;

            // check next position

            if (nextWidth + dirWidth < 0 || nextWidth + dirWidth >= cube.GetLength(0))
            {
                dirWidth *= -1;
            }
            if (nextHeight + dirHeight < 0 || nextHeight + dirHeight >= cube.GetLength(1))
            {
                dirHeight *= -1;
            }
            if (nextDepth + dirDepth < 0 || nextDepth + dirDepth >= cube.GetLength(2))
            {
                dirDepth *= -1;
            }


            nextWidth += dirWidth;
            nextHeight += dirHeight;
            nextDepth += dirDepth;

            if (cube[nextWidth, nextHeight, nextDepth])
            {
                break;
            }
        }

        // print current position
        Console.WriteLine("{0} {1} {2}", currentWidth + 1, currentHeight + 1, currentDepth + 1);
    }

    private static void MarkBurnt(int cubeWidth, int cubeHeight, int cubeDepth, bool[, ,] cube)
    {
        for (int w = 0; w < cubeWidth; w++)
        {
            cube[w, 0, 0] = true;
            cube[w, cubeHeight - 1, 0] = true;
            cube[w, 0, cubeDepth - 1] = true;
            cube[w, cubeHeight - 1, cubeDepth - 1] = true;
        }

        for (int d = 0; d < cubeDepth; d++)
        {
            cube[0, 0, d] = true;
            cube[cubeWidth - 1, 0, d] = true;
            cube[0, cubeHeight - 1, d] = true;
            cube[cubeWidth - 1, cubeHeight - 1, d] = true;
        }

        for (int h = 0; h < cubeHeight; h++)
        {
            cube[0, h, 0] = true;
            cube[cubeWidth - 1, h, 0] = true;
            cube[0, h, cubeDepth - 1] = true;
            cube[cubeWidth - 1, h, cubeDepth - 1] = true;
        }
    }
}