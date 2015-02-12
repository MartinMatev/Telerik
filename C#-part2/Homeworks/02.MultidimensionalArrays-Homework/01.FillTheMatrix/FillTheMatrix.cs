using System;

// Write a program that fills and prints a matrix of size 
// `(n, n)` as shown below:
/*
 * Example for n=4:

   a)		     b)                                                      
    1 5 9	13    1	8 9	16                                            
    2 6 10	14    2	7 10 15                                           
    3 7 11	15    3	6 11 14                                           
    4 8 12	16    4	5 12 13                                           
    
   c)                 d)*          
     7	11	14	16      1 12 11	10
     4	8	12	15      2 13 16	9 
     2	5	9	13      3 14 15	8 
     1	3	6	10      4 5	 6  7 
 */
class Program
{
    static void Main()
    {
        int length;
        Console.Write("Type in array's length: ");
        if (int.TryParse(Console.ReadLine(), out length) && length > 0)
        {
            
            int count = 1;           
            FillMatrixA(length, count);
            FillMatrixB(length, count);
            FillMatrixC(length, count);
            FillMatrixD(length, count);            
        }
    }
    static void FillMatrixA(int length, int count)
    {
        int[,] matrix = new int[length, length];

        for (int col = 0; col < length; col++)
        {
            for (int row = 0; row < length; row++)
            {
                matrix[row, col] = count;
                count++;
            }
        }
        PrintMatrix(matrix, length);
    }
    static void FillMatrixB(int length, int count)
    {
        int[,] matrix = new int[length, length];
        for (int col = 0; col < length; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < length; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
            {
                for (int row = length - 1; row >= 0; row--)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
        }
        PrintMatrix(matrix, length);
    }
    static void FillMatrixC(int length, int count)
    {
        int[,] matrix = new int[length, length];
        // Fill the bottom half
        for (int row = length - 1; row >= 0; row--)
        {
            for (int col = 0; col < length - row; col++)
            {
                matrix[row + col, col] = count++;
            }
        }
        // Fill the upper half
        for (int col = 1; col < length; col++)
        {
            for (int row = 0; row < length - col; row++)
            {
                matrix[row, col + row] = count++;
            }
        }
        PrintMatrix(matrix, length);
    }
    static void FillMatrixD(int length, int count)
    {
        int[,] matrix = new int[length, length];
        string direction = "down";
        int currentRow = 0;
        int currentCol = 0;
        int limit = length * length;
        count = 0;

        for (int i = 1; i <= limit; i++)
        {
            // Check for the direction and If the counter has reached the max lenght of the array OR if the next member of the matrix is a number (meaning we already been there and it's time to turn, so we dont overwrite the number we assigned earlier)
            if (direction == "down" && (count == length || matrix[currentRow, currentCol] != 0))
            {
                // If we are in here that means it's time to turn. Change the direction, move BACK one row, because we are already out of the matrix, and move to the right by going to the next column. Reset the counter to 1 (not 0, because we already moved 1 column !)
                direction = "right";
                currentRow--;
                currentCol++;
                count = 1;
            }
            else if (direction == "right" && (count == length || matrix[currentRow, currentCol] != 0))
            {
                direction = "up";
                currentCol--;
                currentRow--;
                count = 1;
            }
            else if (direction == "up" && (count == length || matrix[currentRow, currentCol] != 0))
            {
                direction = "left";
                currentRow++;
                currentCol--;
                count = 1;
            }
            else if (direction == "left" && (count == length || matrix[currentRow, currentCol] != 0))
            {
                direction = "down";
                currentCol++;
                currentRow++;
                count = 1;
            }

            // Up the lenght counter by 1, and initialze the current row and col with the appropriate number
            count++;
            matrix[currentRow, currentCol] = i;

            // Check the current direction and move the appropriate row/col -  up/down/back/forward
            if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
        }
        PrintMatrix(matrix, length);
    }
    // Displaying the matrices
    static void PrintMatrix(int[,] matrix, int length)
    {
        for (int row = 0; row < length; row++)
        {
            for (int col = 0; col < length; col++)
            {
                Console.Write("{0, 5}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        Array.Clear(matrix, 0, length);
        Console.WriteLine(new string('-', length * 5));
    }
}
