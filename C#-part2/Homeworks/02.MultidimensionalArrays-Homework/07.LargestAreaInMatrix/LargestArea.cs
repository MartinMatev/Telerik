using System;
using System.Linq;

/*
 * Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
 * Example:

 * matrix	            result
 * 1 3 2 2 2 4          13
 * 3 3 3 2 4 4
 * 4 3 1 2 3 3
 * 4 3 1 3 3 1
 * 4 3 3 3 1 1
 */
class LargestArea
{
    static void Main()
    {
        int rows = GetSize("rows");
        int cols = GetSize("cols");
        int[,] numbersArray = FillMatrix(rows, cols);
        FindLargestArea(numbersArray, rows, cols);
    }

    private static void FindLargestArea(int[,] numbersArray, int rows, int cols)
    {
        bool[,] visited = new bool[rows, cols];
        int bestCount = 0;
        int indexRow = 0;
        int indexCol = 0;
        // Search for branches, starting from every cell, mark with true the already visited ones
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (visited[row, col] == false)
                {
                    int count = DepthFirstSearch(numbersArray, visited, row, col);
                    if (bestCount < count)
                    {
                        bestCount = count;
                        indexRow = row;
                        indexCol = col;
                    }
                }
            }
        }
        PrintResult(bestCount, numbersArray[indexRow, indexCol]);
    }

    private static void PrintResult(int bestCount, int element)
    {
        Console.WriteLine("The size of the largest area of equal neighbour elements is: {0}", bestCount);
        Console.WriteLine("The element is: {0}", element);
    }
    // Recursive method
    private static int DepthFirstSearch(int[,] numbersArray, bool[,] visited, int row, int col)
    {
        int result = 1;
        // Checks the current cell as true in the visited array, to ignore it from now on
        visited[row, col] = true;

        // First check of every IF is a check for the array boundries (so we don't go out)
        // Second check is if there is a branch, meaning a neghbour cell with the same value
        // Third check is to see if we still havent check that cell (i.e its false in the visited array)
        if ((row - 1 >= 0) && (numbersArray[row - 1, col] == numbersArray[row, col]) && !visited[row - 1, col])
        {
            result += DepthFirstSearch(numbersArray, visited, row - 1, col);
        }
        if ((row + 1 < numbersArray.GetLength(0)) && (numbersArray[row + 1, col] == numbersArray[row, col]) && !visited[row + 1, col])
        {
            result += DepthFirstSearch(numbersArray, visited, row + 1, col);
        }
        if ((col - 1 >= 0) && (numbersArray[row, col - 1] == numbersArray[row, col]) && !visited[row, col - 1])
        {
            result += DepthFirstSearch(numbersArray, visited, row, col - 1);
        }
        if ((col + 1 < numbersArray.GetLength(1)) && numbersArray[row, col + 1] == numbersArray[row, col] && !visited[row, col + 1])
        {
            result += DepthFirstSearch(numbersArray, visited, row, col + 1);
        }
        return result;
    }
    // A method for filling up the matrix
    private static int[,] FillMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Type in values of rows below (rows == {0}, cols == {1})", rows, cols);
        Console.WriteLine("Separate numbers by space or `,`");
        for (int row = 0; row < rows; row++)
        {
            Console.Write("Row {0}/{1}: ", row + 1, rows);
            int[] inputNumbers = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(x => int.Parse(x))
                                                   .ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = inputNumbers[col];
            }
        }
        return matrix;
    }

    private static int GetSize(string dimensions)
    {
        Console.Write("Type in the number of {0}: ", dimensions);
        int size = int.Parse(Console.ReadLine());
        return size;
    }

}
