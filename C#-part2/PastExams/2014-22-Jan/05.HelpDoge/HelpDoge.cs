﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class HelpDoge
{
    static int fx;
    static int fy;
    static void Main()
    {
        var field = Input();

        for (int x = 0; x < field.GetLength(0); x++)
        {
            for (int y = 0; y < field.GetLength(1); y++)
            {
                // special cases below
                if (x == 0 && y == 0)
                {
                    field[0, 0] = 1;
                    continue;
                }

                if (field[x, y] == -1)
                {
                    field[x, y] = 0;
                    continue;
                }

                if (x == 0)
                {
                    field[0, y] = field[0, y - 1];
                    continue;
                }

                if (y == 0)
                {
                    field[x, 0] = field[x - 1, 0];
                    continue;
                }

                // normal cases
                field[x, y] = field[x - 1, y] + field[x, y - 1];
            }   
        }

        Console.WriteLine(field[fx, fy]);
    }

    private static BigInteger[,] Input()
    {
        string line = Console.ReadLine();
        var numbersAsStrings = line.Split(' ');
        int n = int.Parse(numbersAsStrings[0]);
        int m = int.Parse(numbersAsStrings[1]);

        numbersAsStrings = Console.ReadLine().Split(' ');
        fx = int.Parse(numbersAsStrings[0]);
        fy = int.Parse(numbersAsStrings[1]);
        int k = int.Parse(Console.ReadLine());

        BigInteger[,] field = new BigInteger[n, m];
        for (int i = 0; i < k; i++)
        {
            line = Console.ReadLine();
            numbersAsStrings = line.Split(' ');
            int x = int.Parse(numbersAsStrings[0]);
            int y = int.Parse(numbersAsStrings[1]);

            field[x, y] = -1;
        }

        return field;
    }
}
