using System;

/*
 * We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix.
Example:

    matrix:	            result:		    matrix:	        result:
    ha	fifi ho	hi      ha, ha, ha      s	qq	s       s, s, s
    fo	ha	 hi	xx                      pp	pp	s
    xxx	ho	 ha	xx                      pp	qq	s
    		   
 */
class SequenceMatrix
{
    static void Main()
    {
        int rows = GetSize("rows");
        int cols = GetSize("cols");
        string[,] stringMatrix = GetInput(rows, cols);      
        Console.WriteLine(FindLongestSequence(stringMatrix, rows, cols));
    }

    private static string FindLongestSequence(string[,] stringMatrix, int rows, int cols)
    {
        int max = 0;
        int right = 0;
        int down = 0;
        int diagonal = 0;
        int temp = 0;
        string mostFrequentStr = "";

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                string currentStr = stringMatrix[row, col];
                right = CheckSides(stringMatrix, row, col, "right");
                down = CheckSides(stringMatrix, row, col, "down");
                diagonal = CheckSides(stringMatrix, row, col, "diagonal");
                temp = Math.Max(Math.Max(right, down), diagonal);

                if (temp > max)
                {
                    max = temp;
                    mostFrequentStr = currentStr;
                }
            }

            if (max == rows)
            {
                return DisplayResult(stringMatrix, max, mostFrequentStr); 
            }
        }
        return DisplayResult(stringMatrix, max, mostFrequentStr);
    }

    private static int CheckSides(string[,] stringMatrix, int startRow, int startCol, string direction)
    {
        int count = -1;
        // Check everything to the right of our current position
        if (direction == "right")
        {
            count = 0;
            for (int nextCol = startCol; nextCol < stringMatrix.GetLength(1); nextCol++)
            {
                if (stringMatrix[startRow, nextCol] == stringMatrix[startRow, startCol])
                {
                    count++;
                }
            }
        }
        else if (direction == "down")
        {
            count = 0;
            for (int nextRow = startRow; nextRow < stringMatrix.GetLength(0); nextRow++)
            {
                if (stringMatrix[nextRow, startCol] == stringMatrix[startRow, startCol])
                {
                    count++;
                }
            }
        }
        else if (direction == "diagonal")
        {
            count = 0;
            for (int nextRow = startRow, nextCol = startCol; nextRow < stringMatrix.GetLength(0) && nextCol < stringMatrix.GetLength(1); nextRow++, nextCol++)
            {
                if (stringMatrix[nextRow, nextCol] == stringMatrix[startRow, startCol])
                {
                    count++;
                }
            }
        }

        return count;
    }

    private static string DisplayResult(string[,] stringMatrix, int max, string mostFrequentStr)
    {
        Console.WriteLine("\nYour matrix looks like this: ");
        for (int row = 0; row < stringMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < stringMatrix.GetLength(1); col++)
            {
                Console.Write(" {0, -5}", stringMatrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nThe most frequent string in it is: ");
        string result = "";
        for (int i = 0; i < max; i++)
        {
            result += mostFrequentStr + ", ";
        }
        //Console.WriteLine(result);
        return result;
    }

    private static int GetSize(string dimensions)
    {
        Console.Write("Enter the {0} of the array: ", dimensions);
        int size = int.Parse(Console.ReadLine());
        return size;
    }

    private static string[,] GetInput(int rows, int cols)
    {
        Console.WriteLine("Enter matrix (rows = {0} && cols = {1})", rows, cols);
        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            Console.Write("Enter values(separated by `,` or space) of row {0}/{1}: ", row + 1, rows);
            string[] input = Console.ReadLine().Split(new string[] { " ", ",", "\t" }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];    
            }
        }
        return matrix;
    }
}
