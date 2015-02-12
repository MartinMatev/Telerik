using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhead
{
    class Warhead
    {
        static int[,] matrix = new int[16, 16];
        static void Main(string[] args)
        {
            string from = "";
            int finalCapacitatorCount = 0;
            int removedRedCapacitators = 0;
            int removedBlueCapacitators = 0;

            for (int row = 0; row < 16; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < 16; col++)
                {
                    matrix[row, col] = input[col] - '0';
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "hover" || command == "operate")
                {
                    int commandRow = int.Parse(Console.ReadLine());
                    int commandCol = int.Parse(Console.ReadLine());

                    if (command == "hover")
                    {
                        if (matrix[commandRow, commandCol] == 1)
                        {
                            Console.WriteLine('*');
                        }
                        else if (matrix[commandRow, commandCol] == 0)
                        {
                            Console.WriteLine('-');
                        }
                    }
                    else if (command == "operate")
                    {
                        int[,] currentSelection = new int[3, 3];
                        int currentRow = 0;
                        int currentCol = 0;

                        if (matrix[commandRow, commandCol] == 1)
                        {
                            from = "missed";
                            finalCapacitatorCount = CountCapacitators(finalCapacitatorCount, from);
                            Console.WriteLine("missed");
                            Console.WriteLine(finalCapacitatorCount);
                            Console.WriteLine("BOOM");
                            return;
                        }
                        else if (matrix[commandRow, commandCol] == 0)
                        {
                            // Loop thorugh matrix to separate area into new array
                            for (int row = commandRow - 1; row <= commandRow + 1; row++)
                            {
                                for (int col = commandCol - 1; col <= commandCol + 1; col++)
                                {
                                    if (row <= 15 && row >= 0 && col <= 15 && col >= 0)
                                    {
                                        currentSelection[currentRow, currentCol] = matrix[row, col];
                                    }
                                    else
                                    {
                                        currentSelection[currentRow, currentCol] = 0;
                                    }
                                    currentCol++;
                                }
                                currentRow++;
                                currentCol = 0;
                            }

                            int countCapacitators = 0;
                            // Loop through the new array to count capacitators
                            for (int row = 0; row < 3; row++)
                            {
                                for (int col = 0; col < 3; col++)
                                {
                                    if (currentSelection[row, col] == 1)
                                    {
                                        countCapacitators++;
                                    }
                                }
                            }

                            if (countCapacitators == 8)
                            {
                                // Loop through original MATRIX and set capacitators to 0s
                                for (int row = commandRow - 1; row <= commandRow + 1; row++)
                                {
                                    for (int col = commandCol - 1; col <= commandCol + 1; col++)
                                    {
                                        matrix[row, col] = 0;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (command == "cut")
                {
                    string sideToCut = Console.ReadLine();

                    if (sideToCut == "red")
                    {
                        from = "red";
                        finalCapacitatorCount = CountCapacitators(finalCapacitatorCount, from);
                        if (finalCapacitatorCount == 0) // IF THE RED ONES ARE 0
                        {
                            from = "blue";
                            finalCapacitatorCount = CountCapacitators(finalCapacitatorCount, from);
                            Console.WriteLine(finalCapacitatorCount);
                            Console.WriteLine("disarmed");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(finalCapacitatorCount);
                            Console.WriteLine("BOOM");
                            return;
                        }

                    }
                    else // sideToCut == "blue"
                    {
                        from = "blue";
                        finalCapacitatorCount = CountCapacitators(finalCapacitatorCount, from);
                        if (finalCapacitatorCount == 0) // IF THE BLUE ARE 0
                        {
                            from = "red";
                            finalCapacitatorCount = CountCapacitators(finalCapacitatorCount, from);
                            Console.WriteLine(finalCapacitatorCount);
                            Console.WriteLine("disarmed");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(finalCapacitatorCount);
                            Console.WriteLine("BOOM");
                            return;
                        }
                    }
                    
                }
            }
        }
        static int CountCapacitators(int count, string from)
        {            
            int blueCapacitatorCount = 0;
            int redCapacitatorCount = 0;

            for (int row = 1; row < 15; row++)
            {
                for (int col = 1; col < 15; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        int capacitatorParts = 0;

                        if (matrix[row - 1, col - 1] == 1 &&
                            matrix[row - 1, col] == 1 &&
                            matrix[row - 1, col + 1] == 1 &&
                            matrix[row, col - 1] == 1 &&
                            matrix[row, col + 1] == 1 &&
                            matrix[row + 1, col - 1] == 1 &&
                            matrix[row + 1, col] == 1 &&
                            matrix[row + 1, col + 1] == 1)
                        {
                            capacitatorParts = 8;
                        }
                        if (capacitatorParts == 8 && col < 15 / 2)
                        {
                            redCapacitatorCount++;
                        }
                        else if (capacitatorParts == 8 && col >= 15 / 2)
                        {
                            blueCapacitatorCount++;
                        }
                    }
                }
            }

            switch (from)
            {
                case "blue":
                    count = blueCapacitatorCount;
                    break;
                case "red":
                    count = redCapacitatorCount;
                    break;
                case "missed":
                    count = blueCapacitatorCount + redCapacitatorCount;
                    break;
                default:
                    break;
            }
            return count;
        }
    }
}
