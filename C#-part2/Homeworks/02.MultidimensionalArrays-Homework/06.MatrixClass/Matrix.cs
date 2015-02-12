using System;
using System.Text;

class Matrix
{
    // fields
    private int[,] matrix;

    // constructor
    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }
    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }
    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }
    // Adding matrices
    public static Matrix operator +(Matrix matrixA, Matrix matrixB)
    {
        Matrix resultMatrix = new Matrix(matrixA.Rows, matrixA.Columns);
        for (int row = 0; row < matrixA.Rows; row++)
        {
            for (int col = 0; col < matrixA.Columns; col++)
            {
                resultMatrix[row, col] = matrixA[row, col] + matrixB[row, col];
            }
        }
        return resultMatrix;
    }
    // Substracting matrices
    public static Matrix operator -(Matrix matrixA, Matrix matrixB)
    {
        Matrix resultMatrix = new Matrix(matrixA.Rows, matrixA.Columns);
        for (int row = 0; row < matrixA.Rows; row++)
        {
            for (int col = 0; col < matrixB.Columns; col++)
            {
                resultMatrix[row, col] = matrixA[row, col] - matrixB[row, col];
            }
        }
        return resultMatrix;
    }
    // Multiplying matrices
    public static Matrix operator *(Matrix matrixA, Matrix matrixB)
    {
        Matrix resultMatrix = new Matrix(matrixA.Rows, matrixB.Columns);
        for (int row = 0; row < matrixA.Rows; row++)
        {
            for (int col = 0; col < matrixB.Columns; col++)
            {
                for (int i = 0; i < matrixA.Columns; i++)
                {
                    resultMatrix[row, col] += matrixA[row, i] * matrixB[i, col];
                }
            }
        }
        return resultMatrix;
    }
    // Indexer
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col] = value;
        }
    }

    // Override toString
    public override string ToString()
    {
        StringBuilder resultString = new StringBuilder();
        // this.Rows == this.matrix.GetLength(0)
        for (int row = 0; row < this.Rows; row++)
        {
            // this.Columns == this.matrix.GetLength(1)
            for (int col = 0; col < this.Columns; col++)
            {
                string currentValue = string.Format("{0, 5}", matrix[row, col]);
                resultString.Append(currentValue);
            }
            resultString.AppendLine();
        }

        return resultString.ToString();
    }
}
