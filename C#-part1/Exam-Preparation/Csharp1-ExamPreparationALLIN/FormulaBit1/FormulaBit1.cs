using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaBit1
{
    class FormulaBit1
    {
        static void Main(string[] args)
        {
            string direction = "south";
            int turnCounter = 0;
            int trackLength = 0;
            int[,] matrix = new int[8, 8];

            // Filling up the matrix (creating the GRID)
            for (int row = 0; row < 8; row++)
            {
                byte num = byte.Parse(Console.ReadLine());
                string binaryNum = Convert.ToString(num, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = binaryNum[col] - '0';      
                }
            }

            // Iterating through the matrix to find appropriate path

            int currentRow = 0;
            int currentCol = 7;
            bool notEnoughTrack = false;
            bool fromSouth = true;
            while (matrix[currentRow, currentCol] == 0)
            {
                if (direction == "south")
                {
                    if (currentRow < 7 && matrix[currentRow + 1, currentCol] == 0)
                    {
                        currentRow++;
                        trackLength++;
                    }
                    else if ((currentRow + 1 > 7 || matrix[currentRow + 1, currentCol] == 1) &&
                            matrix[currentRow, currentCol - 1] == 0 && currentCol > 0)
                    {
                        currentCol--;
                        direction = "west";
                        turnCounter++;
                        trackLength++;
                        fromSouth = true;
                    }
                    else
                    {
                        notEnoughTrack = true;
                        break;
                    }
                }
                else if (direction == "west")
                {
                    if (currentCol > 0 && matrix[currentRow, currentCol - 1] == 0)
                    {
                        currentCol--;
                        trackLength++;
                    }
                    else if ((currentCol - 1 < 0 || matrix[currentRow, currentCol - 1] == 1) &&
                            (currentRow - 1 < 0  || matrix[currentRow - 1, currentCol] == 0) && 
                            fromSouth)
                    {
                        currentRow--;
                        direction = "north";
                        turnCounter++;
                        trackLength++;
                    }
                    else if ((currentCol - 1 < 0 || matrix[currentRow, currentCol - 1] == 1) &&
                            (currentRow  + 1 < 7 || matrix[currentRow + 1, currentCol] == 0) &&
                             !fromSouth)
                    {
                        currentRow++;
                        direction = "south";
                        turnCounter++;
                        trackLength++;
                    }
                    else
                    {
                        notEnoughTrack = true;
                        break;
                    }
                }
                else if (direction == "north")
                {
                    if (currentRow > 0 && matrix[currentRow - 1, currentCol] == 0)
                    {
                        currentRow--;
                        trackLength++;
                    }
                    else if (currentCol > 0 && 
                            ( currentRow - 1 < 0 || matrix[currentRow - 1, currentCol] == 1) &&
                            matrix[currentRow, currentCol - 1] == 0)
                    {
                        currentCol--;
                        direction = "west";
                        turnCounter++;
                        trackLength++;
                        fromSouth = false;
                    }
                    else
                    {
                        notEnoughTrack = true;
                        break;
                    }
                }

                if (currentRow == 7 && currentCol == 0)
                {
                    break;
                }
            }

            if (trackLength == 0)
            {
                Console.WriteLine("No {0}", trackLength);
            }
            else if (notEnoughTrack)
            {
                trackLength++;
                Console.WriteLine("No {0}", trackLength);
            }
            else
            {
                trackLength++;
                Console.WriteLine("{0} {1}", trackLength, turnCounter);
            }
        }
    }
}
