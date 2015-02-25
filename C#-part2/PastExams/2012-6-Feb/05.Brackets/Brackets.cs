using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class Brackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int length = input.Length;
        BigInteger[,] bracketsArray = new BigInteger[length + 1, length + 2];
        bracketsArray[0, 0] = 1;

        for (int row = 1; row <= length; row++)
        {
            if (input[row - 1] == '(')
            {
                bracketsArray[row, 0] = 0;
            }
            else
            {
                bracketsArray[row, 0] = bracketsArray[row - 1, 1];
            }
            for (int col = 1; col <= length; col++)
            {
                if (input[row - 1] == '(')
                {
                    bracketsArray[row, col] = bracketsArray[row - 1, col - 1];
                }
                else if (input[row - 1] == ')')
                {
                    bracketsArray[row, col] = bracketsArray[row - 1, col + 1];
                }
                else
                {
                    bracketsArray[row, col] = bracketsArray[row - 1, col - 1] + bracketsArray[row - 1, col + 1];
                }
            }
        }
        Console.WriteLine(bracketsArray[length, 0]);
    }
}
