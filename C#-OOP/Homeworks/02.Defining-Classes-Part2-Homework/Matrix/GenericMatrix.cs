using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class GenericMatrix<T> where T: IComparable<T>
    {
        // fields
        private T[,] matrix;
        private int rows;
        private int cols;

        // constructor
        public GenericMatrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        // properties
        public int Rows 
        {
            get
            {
                return this.rows;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Rows cannot be less than 1");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Cols cannot be less than 1");
                }

                this.cols = value;
            }
        }

        // Required methods below

        // Matrix Indexer

        public T this[int row, int col]
        {
            // Return the element at the given index
            get
            {
                // Check for failure
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("No such index/indexes!");
                }

                return this.matrix[row, col];
            }

            set
            {
                // Fail check
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("No such index/indexes!");
                }

                this.matrix[row, col] = value;
            }
        }

        // Operators overrides below

        // Override +
        public static GenericMatrix<T> operator +(GenericMatrix<T> a, GenericMatrix<T> b)
        {
            if ((a.Rows != b.Rows) || (a.Cols != b.Cols))
            {
                throw new ArgumentOutOfRangeException("Matrices must be of the same size");
            }

            GenericMatrix<T> resultMatrix = new GenericMatrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    resultMatrix[row, col] = (dynamic)a[row, col] + b[row, col];
                }
            }
            return resultMatrix;
        }

        // Override -
        public static GenericMatrix<T> operator -(GenericMatrix<T> a, GenericMatrix<T> b)
        {
            if ((a.Rows != b.Rows) || (a.Cols != b.Cols))
            {
                throw new ArgumentOutOfRangeException("Matrices must be of the same size");
            }

            GenericMatrix<T> resultMatrix = new GenericMatrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    resultMatrix[row, col] = (dynamic)a[row, col] - b[row, col];
                }
            }
            return resultMatrix;
        }

        // Override *
        public static GenericMatrix<T> operator *(GenericMatrix<T> a, GenericMatrix<T> b)
        {
            if (a.Rows != b.Cols)
            {
                throw new ArgumentOutOfRangeException("Matrix `a` rows must match matrix `b` cols");
            }
            GenericMatrix<T> resultMatrix = new GenericMatrix<T>(a.Rows, b.Cols);

            for (int currentRow = 0; currentRow < a.Rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < b.Cols; currentCol++)
                {
                    for (int i = 0; i < a.Cols; i++)
                    {
                        resultMatrix[currentRow, currentCol] += (dynamic)a[currentRow, i] * b[i, currentCol];
                    }
                }
            }
            return resultMatrix;
        }

        // Override true
        public static bool operator true(GenericMatrix<T> matrix)
        {
            return BoolCheck(matrix);
        }
        // Override false
        public static bool operator false(GenericMatrix<T> matrix)
        {
            return BoolCheck(matrix);
        }

        private static bool BoolCheck(GenericMatrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Override ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int currentRow = 0; currentRow < this.Rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < this.Cols; currentCol++)
                {
                    result.Append(this.matrix[currentRow, currentCol]).Append('\t');
                }
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
