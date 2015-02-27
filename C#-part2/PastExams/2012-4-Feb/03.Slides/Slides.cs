using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Slides
{
    static int cuboidWidth;
    static int cuboidHeight;
    static int cuboidDepth;
    static string[, ,] cuboid;
    static int ballWidth;
    static int ballHeight;
    static int ballDepth;
    static void Main()
    {
        ReadInput();

        bool canDrop = true;
        int nextWidth = ballWidth;
        int nextHeight = ballHeight;
        int nextDepth = ballDepth;
        string currentCube = string.Empty;

        while (canDrop)
        {
            // out of the cuboid
            if (nextHeight == cuboidHeight)
            {
                break;
            }
            // it hit a wall
            if (0 > nextWidth || nextHeight > cuboidWidth - 1 ||
                0 > nextDepth || nextDepth > cuboidDepth - 1)
            {
                canDrop = false;
                break;
            }

            // Keep tarck of every cube, so we know the last one when we leave the cycle
            ballWidth = nextWidth;
            ballHeight = nextHeight;
            ballDepth = nextDepth;

            // read current cube
            currentCube = cuboid[nextWidth, nextHeight, nextDepth];

            // execute current cube command
            char command = currentCube[0];
            switch (command)
            {
                case 'B': canDrop = false; break;
                case 'E': nextHeight++; break;
                case 'T':   // "T 1 1"
                    int[] coords = currentCube.Substring(2).Split(' ').Select(x => int.Parse(x)).ToArray();
                    nextWidth = coords[0];
                    nextDepth = coords[1];
                    break;
                case 'S': // S L; R; F; B; FL; FR; BL; BR
                    nextHeight++;
                    string direction = currentCube.Substring(2);
                    switch (direction)
                    {
                        case "L": nextWidth--; break;
                        case "R": nextWidth++; break;
                        case "F": nextDepth--; break;
                        case "B": nextDepth++; break;
                        case "FL":
                            nextDepth--;
                            nextWidth--;    
                            break;
                        case "FR":
                            nextDepth--;
                            nextWidth++;
                            break;
                        case "BL":
                            nextDepth++;
                            nextWidth--;
                            break;
                        case "BR":
                            nextDepth++;
                            nextWidth++;
                            break;
                    }

                    break;
            }
        }

        // output
        Console.WriteLine(canDrop ? "Yes" : "No");
        Console.WriteLine("{0} {1} {2}", ballWidth, ballHeight, ballDepth);
    }

    private static void ReadInput()
    {
        string[] inputLine = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        cuboidWidth = int.Parse(inputLine[0]);
        cuboidHeight = int.Parse(inputLine[1]);
        cuboidDepth = int.Parse(inputLine[2]);
        cuboid = new string[cuboidWidth, cuboidHeight, cuboidDepth];

        for (int h = 0; h < cuboidHeight; h++)
        {
            inputLine = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            for (int d = 0; d < cuboidDepth; d++)
            {
                string[] cubes = inputLine[d].Trim().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < cuboidWidth; w++)
                {
                    string cube = cubes[w];
                    cuboid[w, h, d] = cube;
                }
            }
        }

        inputLine = Console.ReadLine().Split(' ');
        ballWidth = int.Parse(inputLine[0]);
        ballHeight = 0;
        ballDepth = int.Parse(inputLine[1]);


    }
}
