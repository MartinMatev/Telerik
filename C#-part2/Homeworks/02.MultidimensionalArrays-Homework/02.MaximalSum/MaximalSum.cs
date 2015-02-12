using System;
using System.Linq;

// Write a program that reads a rectangular matrix of size N x M 
// and finds in it the square 3 x 3 that has maximal sum of its elements.
class MaximalSum
{
    static void Main()
    {
        int rows = GetSize("rows");
        int cols = GetSize("cols");
        int[,] matrix = GetMatrix(rows, cols);
        FindMaximalSum(matrix, rows, cols);
    }

    private static void FindMaximalSum(int[,] matrix, int rows, int cols)
    {
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int currentSum = 0;
                // Loop the 3x3 square
                for (int squareRow = row; squareRow <= row + 2; squareRow++)
                {
                    for (int squareCol = col; squareCol <= col + 2; squareCol++)
                    {
                        currentSum += matrix[squareRow, squareCol];
                    }
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        PrintMatrix(matrix, bestRow, bestCol, bestSum);
    }

    private static void PrintMatrix(int[,] matrix, int bestRow, int bestCol, int bestSum)
    {
        Console.WriteLine("The 3x3 square with the best sum is: ");
        for (int squareRow = bestRow; squareRow <= bestRow + 2; squareRow++)
        {
            for (int squareCol = bestCol; squareCol <= bestCol + 2; squareCol++)
            {
                Console.Write("{0, 5}", matrix[squareRow, squareCol]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("With a total sum of {0}", bestSum);
    }
    static int GetSize(string dimension)
    {
        int size;
        Console.Write("Enter the size of the {0} ({0} >= 3): ", dimension);
        if (int.TryParse(Console.ReadLine(), out size) && size >= 3)
        {
            return size;
        }
        Console.WriteLine("Incorrect size value of {0}, assigning 3 by default!", dimension);
        return 3;
    }
    private static int[,] GetMatrix(int rows, int cols)
    {
        Console.WriteLine("Enter matrix (rows = {0} && cols = {1})", rows, cols);
        int[,] matrix = new int[rows, cols]; 
        for (int row = 0; row < rows; row++)
        {
            Console.Write("Enter values(separated by `,` or space) of row {0}/{1}: ", row + 1, rows);
            int[] input = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(x => int.Parse(x))
                                            .ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
            }
        }
        return matrix;

    }
}
