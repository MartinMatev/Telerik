using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfPage
{
    class GameOfPage
    {
        static int[,] matrix = new int[16, 16];
        static double sum = 0;
        static void Main(string[] args)
        {
            for (int row = 0; row < 16; row++)
            {
                string inputLine = Console.ReadLine();

                for (int col = 0; col < 16; col++)
                {
                    matrix[row, col] = (int)Char.GetNumericValue(inputLine[col]);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "paypal")
                {
                    break;
                }
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                string output = CheckPosition(row, col, input);

                if (output.Length > 0)
                {
                    Console.WriteLine(output);
                }
            }
            Console.WriteLine("{0:F2}", sum);
        }
        static string CheckPosition(int row, int col, string input)
        {
            int[,] currentSelection = new int[3, 3];
            int currentRow = 0;
            int currentCol = 0;

            for (int matRow = row - 1; matRow <= row + 1; matRow++)
            {
                for (int matCol = col - 1; matCol <= col + 1; matCol++)
                {
                    if (matRow >= 0 && matRow <= 15 && matCol >= 0 && matCol <= 15)
                    {
                        currentSelection[currentRow, currentCol] = matrix[matRow, matCol];
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

            int count = 0;
            for (int newRow = 0; newRow < 3; newRow++)
            {
                for (int newCol = 0; newCol < 3; newCol++)
                {
                    if (currentSelection[newRow, newCol] == 1)
                    {
                        count++;
                    }
                }
            }

            if (input == "what is")
            {
                if (count == 9)
                {
                    return "cookie";
                }
                else if (count == 1 && matrix[row, col] == 1)
                {
                    return "cookie crumb";
                }
                else if (count > 0 && matrix[row, col] == 1)
                {
                    return "broken cookie";
                }
                else
                {
                    return "smile";
                }
            }
            else //If the input == "buy"
            {
                if (count == 9)
                {
                    for (int matRow = row - 1; matRow <= row + 1; matRow++)
                    {
                        for (int matCol = col - 1; matCol <= col + 1; matCol++)
                        {
                            matrix[matRow, matCol] = 0;
                        }
                    }
                    sum += 1.79;
                    return "";
                }
                else if (count == 0)
                {
                    return "smile";
                }
                else // If there something in count, but it's less than 9 (not a whole cookie)
                {
                    return "page";
                }
            }
        }
    }
}
