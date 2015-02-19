using System;
using System.Linq;
using System.IO;

/*
 * Write a program that reads a text file containing a square matrix of numbers.
 * Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
 * The first line in the input file contains the size of matrix N.
 * Each of the next N lines contain N numbers separated by space.
 * The output should be a single number in a separate text file.
 * Example:


 * input	    output
 * 4 
 * 2 3 3 4 
 * 0 2 3 4      17
 * 3 7 1 2 
 * 4 3 3 2	
 */
class MaxAreaSum
{
    static void Main()
    {
        try
        {
            string outputFile = @"../../../ProblemsTextFolder/05.SubMatrixResult.txt";
            string[] lines = File.ReadAllLines("../../../ProblemsTextFolder/05.Matrix.txt");
            int length = int.Parse(lines[0]);
            int[,] matrix = new int[length, length];

            FillMatrix(matrix, lines);
            SubMatrixSum(matrix, outputFile);
            Console.WriteLine("New file was created and biggest sum of submatrix has been written at : {0}", Path.GetFullPath(outputFile));
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void SubMatrixSum(int[,] matrix, string outputFile)
    {
        int bestSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSum = 0;
                // Loop the 2x2 square
                for (int squareRow = row; squareRow <= row + 1; squareRow++)
                {
                    for (int squareCol = col; squareCol <= col + 1; squareCol++)
                    {
                        currentSum += matrix[squareRow, squareCol];
                    }
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                }
            }
        }
        WriteResult(bestSum, outputFile);
    }

    private static void WriteResult(int bestSum, string outputFile)
    {
        File.WriteAllText(outputFile, "The sum of the biggest submatrix is: " + bestSum.ToString());
    }

    private static void FillMatrix(int[,] matrix, string[] lines)
    {
        // Start from 1, because the first row of the file, contains the length
        for (int row = 1; row < lines.Length; row++)
        {
            string[] currentLine = lines[row].Split();
            for (int col = 0; col < currentLine.Length; col++)
            {
                matrix[row - 1, col] = int.Parse(currentLine[col]);
            }
        }
    }
}
