namespace Matrix
{
    using System;
    class MatrixTests
    {
        private static Random rand;
        static void Main()
        {
            rand = new Random();
            // Generating generic matrices
            GenericMatrix<int> firstMatrix = new GenericMatrix<int>(4, 4);
            GenericMatrix<int> secondMatrix = new GenericMatrix<int>(4, 4);

            // Filling up the matrices
            FillMatrix(firstMatrix);
            FillMatrix(secondMatrix);

            // Displaying the matrices
            Console.WriteLine(firstMatrix);
            Console.WriteLine(secondMatrix);

            // Displaying the result of the overriden + operator
            Console.WriteLine("Matrix A + Matrix B");
            Console.WriteLine(firstMatrix + secondMatrix);

            // Displaying the result of the overriden - operator
            Console.WriteLine("Matrix A - Matrix B");
            Console.WriteLine(firstMatrix - secondMatrix);

            firstMatrix = new GenericMatrix<int>(4, 2);
            secondMatrix = new GenericMatrix<int>(2, 4);
            FillMatrix(firstMatrix);
            FillMatrix(secondMatrix);

            // Displaying the result of the overriden * operator
            Console.WriteLine("Matrix A * Matrix B");
            Console.WriteLine(firstMatrix * secondMatrix);

            // Check if matrices contain non zero elements
            Console.WriteLine("Check if matrices contain a non zero value:");
            Console.Write("First matrix: ");
            Console.WriteLine(firstMatrix ? "yes" : "no");
            Console.Write("Second matrix: ");
            Console.WriteLine(secondMatrix ? "yes" : "no");
        }

        private static void FillMatrix(GenericMatrix<int> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    matrix[row, col] = rand.Next(-3,10);
                }
            }
        }
    }
}
