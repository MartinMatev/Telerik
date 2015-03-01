using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TrailsThreeD
{
    static int x, y, z;
    static int[,] matrix;
    static bool[,] visited;
    static string redMoves, blueMoves;

    static void Main()
    {
        ReadInput();
        int rows = y + 1;   // + 1, защото може да се движим по ръбовете
        int cols = 2 * x + 2 * z;
        visited = new bool[rows, cols];
        // Beggining points of red and blue
        int redRow = y / 2;
        int redCol = x / 2;
        int redDir = 0;

        int blueRow = y / 2;
        int blueCol = x + z + x / 2;    // opposite side
        int blueDir = 2;

        // direction arrays
        int[] dRows = { 0, +1, 0, -1 };
        int[] dCols = { +1, 0, -1, 0 };

        int redMoveIndex = 0;
        int blueMoveIndex = 0;

        bool redHasCrashed = false;
        bool blueHasCrashed = false;

        while (!redHasCrashed && !blueHasCrashed)
        {
            char redMove = redMoves[redMoveIndex];
            while (redMove != 'M')
            {
                redDir = ChangeDir(redDir, redMove);
                redMove = redMoves[++redMoveIndex];
            }

            char blueMove = blueMoves[blueMoveIndex];
            while (blueMove != 'M')
            {
                blueDir = ChangeDir(blueDir, blueMove);
                blueMove = blueMoves[++blueMoveIndex];
            }

            int nextRedRow = redRow + dRows[redDir];
            int nextRedCol = redCol + dCols[redDir];
            nextRedCol = (nextRedCol + cols) % cols;

            int nextBlueRow = blueRow + dRows[blueDir];
            int nextBlueCol = blueCol + dCols[blueDir];
            nextBlueCol = (nextBlueCol + cols) % cols;


            if (nextRedRow < 0 || nextRedRow >= rows ||
                visited[nextRedRow, nextRedCol] ||
                (nextRedRow == nextBlueRow &&
                nextRedCol == nextBlueCol))
            {
                redHasCrashed = true;
            }
            else if (!visited[nextRedRow, nextRedCol] ||
                    (nextRedRow == nextBlueRow &&
                    nextRedCol == nextBlueCol))
            {                
                redRow = nextRedRow;
                redCol = nextRedCol;
                blueRow = nextBlueRow;
                blueCol = nextBlueCol;
            }

            if (nextBlueRow < 0 || nextBlueRow >= rows ||
                visited[nextBlueRow, nextBlueCol] ||
                (nextRedRow == nextBlueRow &&
                nextRedCol == nextBlueCol))
            {
                blueHasCrashed = true;
            }
            else if (!visited[nextBlueRow, nextBlueCol] ||
                    (nextRedRow == nextBlueRow &&
                    nextRedCol == nextBlueCol))
            {
                redRow = nextRedRow;
                redCol = nextRedCol;
                blueRow = nextBlueRow;
                blueCol = nextBlueCol;
            }

            if (redHasCrashed || blueHasCrashed)
            {
                break;
            }

            visited[nextRedRow, nextRedCol] = true;
            visited[nextBlueRow, nextBlueCol] = true;

            ++redMoveIndex;
            ++blueMoveIndex;
        }

        if (redHasCrashed && blueHasCrashed)
        {
            Console.WriteLine("DRAW");
        }
        else if (redHasCrashed)
        {
            Console.WriteLine("BLUE");
        }
        else if (blueHasCrashed)
        {
            Console.WriteLine("RED");
        }

        int startRow = y / 2;
        int startCol = x / 2;
        int distance = Math.Abs(startRow - redRow) + Math.Abs(startCol - redCol);
        Console.WriteLine(distance);
    }

    private static int ChangeDir(int redDir, char redMove)
    {
        if (redMove == 'L')
        {
            --redDir;
        }
        else
        {
            ++redDir;
        }
        return (redDir + 4) % 4;
    }

    private static void ReadInput()
    {
        int[] xyz = Console.ReadLine()
                           .Split(' ')
                           .Select(int.Parse)
                           .ToArray();
        x = xyz[0];
        y = xyz[1];
        z = xyz[2];

        redMoves = TransformMoves(Console.ReadLine());
        blueMoves = TransformMoves(Console.ReadLine());
    }

    private static string TransformMoves(string moves)
    {
        StringBuilder builder = new StringBuilder();
        List<char> digits = new List<char>();
        foreach (char move in moves)
        {
            if (char.IsDigit(move))
            {
                digits.Add(move);
            }
            else
            {
                if (digits.Count == 0)
                {
                    digits.Add('1');
                }
                digits.Reverse();
                int count = int.Parse(string.Join(" ", digits));
                builder.Append(move, count);
                digits.Clear();
            }

        }
        return builder.ToString();
    }
}
