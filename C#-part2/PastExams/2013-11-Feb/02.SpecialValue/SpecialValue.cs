using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SpecialValue
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[][] field = new int[N][];
        ReadData(field);
        bool[][] used = new bool[N][];

        for (int i = 0; i < N; i++)
        {
            used[i] = new bool[field[i].Length];
        }

        long max = long.MinValue;
        for (int i = 0; i < field[0].Length; i++)
        {
            long specialValue = FindCurrentSpecialValue(field, i, used);

            if (max < specialValue)
            {
                max = specialValue;
            }
        }

        Console.WriteLine(max);
    }

    // Loop every row of the jagged array looking for paths
    static long FindCurrentSpecialValue(int[][] field, int column, bool[][] used)
    {
        long result = 0;
        int currentRow = 0;

        while (true)
        {
            result++;
            // check if its already visited (and end the game)
            if (used[currentRow][column])
            {
                return long.MinValue;
            }
            // check if its an negative number (and end the game)
            if (field[currentRow][column] < 0)
            {
                result += Math.Abs(field[currentRow][column]);
                return result;
            }
            // if it contains the index of the next row:
            int nextColumn = field[currentRow][column];
            used[currentRow][column] = true;

            column = nextColumn;
            currentRow++;

            if (currentRow == field.GetLength(0))
            {
                currentRow = 0;
            }
        }

        return result;
    }

    static int[][] ReadData(int[][] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            string[] currentLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            field[i] = new int[currentLine.Length];

            for (int j = 0; j < currentLine.Length; j++)
            {
                field[i][j] = int.Parse(currentLine[j]);
            }
        }

        return field;
    }
}
