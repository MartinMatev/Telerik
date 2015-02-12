using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralArray
{
    class Spiral
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] spiral = new int[n, n];

            string direction = "right";
            int currentRow = 0;
            int currentCol = 0;

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right" && (currentCol >= n || spiral[currentRow, currentCol] != 0))
                {
                    direction = "down";
                    currentCol--;
                    currentRow++;

                }
                else if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] != 0))
                {
                    direction = "left";
                    currentRow--;
                    currentCol--;
                }
                else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
                {
                    direction = "up";
                    currentCol++;
                    currentRow--;
                }
                else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
                {
                    direction = "right";
                    currentRow++;
                    currentCol++;
                }

                spiral[currentRow, currentCol] = i;

                if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(spiral[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
