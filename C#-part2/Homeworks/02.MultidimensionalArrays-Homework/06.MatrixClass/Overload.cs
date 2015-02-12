using System;
using System.Text;

// Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, 
// indexer for accessing the matrix content and ToString().
class Overload
{
    static void Main()
    {
        Matrix matrixA = new Matrix(4, 4);
        Matrix matrixB = new Matrix(4, 4);

        for (int row = 0; row < matrixA.Rows; row++)
        {
            for (int col = 0; col < matrixA.Columns; col++)
            {
                matrixA[row, col] = row + col;
                matrixB[row, col] = col - row;
            }
        }
        Console.WriteLine("Original matrix A:");
        Console.WriteLine(matrixA.ToString());
        Console.WriteLine("Original matrix B:");
        Console.WriteLine(matrixB.ToString());
        Matrix sum = matrixA + matrixB;
        Matrix substraction = matrixA - matrixB;
        Matrix multiplication = matrixA * matrixB;
        Console.WriteLine("Matrix A + Matrix B:");
        Console.WriteLine(sum.ToString());
        Console.WriteLine("Matrix A - Matrix B:");
        Console.WriteLine(substraction.ToString());
        Console.WriteLine("Matrix A * Matrix B:");
        Console.WriteLine(multiplication.ToString());
    }
}

