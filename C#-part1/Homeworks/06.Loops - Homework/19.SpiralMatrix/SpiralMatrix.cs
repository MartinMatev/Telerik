using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads from the console a positive integer number n (1 = n = 20) 
// and prints a matrix holding the numbers from 1 to n*n in the form of square spiral.
namespace _19.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number;
            string direction = "right";
            int row = 0;
            int col = 0;
            int counter = 0;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                int limit = number * number;
                int[,] matrix = new int[number, number];

                // A loop for iterating through the array, assigning the appropriate values
                // and keeping track of directions (changing them when needed).
                for (int i = 1; i <= limit; i++)
                {
                    // Checks if the counter has reached the walls of the array (meaning the max possible digits per row/col)
                    // OR if the next digit in that direction is anything BUT 0 (meaning we have already been there and assigned a digit, so its time to turn).
                    if (direction == "right" && (counter == number || matrix[row, col] != 0))
                    {
                        counter = 1;
                        direction = "down";
                        col--;
                        row++;
                    }
                    else if (direction == "down" && (counter == number || matrix[row, col] != 0))
                    {
                        counter = 1;
                        direction = "left";
                        row--;
                        col--;
                    }
                    else if (direction == "left" && (counter == number || matrix[row, col] != 0))
                    {
                        counter = 1;
                        direction = "up";
                        col++;
                        row--;
                    }
                    else if (direction == "up" && (counter == number || matrix[row, col] != 0))
                    {
                        counter = 1;
                        direction = "right";
                        row++;
                        col++;
                    }

                    counter++;                   
                    matrix[row, col] = i;

                    // Check the direction and keep going in that way (by assigning new values to row or col)
                    if (direction == "right")
                    {
                        col++;
                    }
                    else if (direction == "down")
                    {
                        row++;
                    }
                    else if (direction == "left")
                    {
                        col--;
                    }
                    else
                    {
                        row--;
                    }

                }
                // A set of nested loops for displaying the values of the array in the form of a matrix
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("{0, 4}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
