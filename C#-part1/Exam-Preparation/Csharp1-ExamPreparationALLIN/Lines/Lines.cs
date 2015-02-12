using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Lines
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            int lines = 0;
            int bestLineLenght = 0;
            int currentLineLenght;

            // Create field
            for (int row = 0; row < 8; row++)
            {
                string number = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = number[col] - '0';
                }
            }

            // Check rows for lines
            for (int row = 0; row < 8; row++)
            {
                currentLineLenght = 0;
                for (int col = 0; col < 8; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        currentLineLenght++;
                        if (currentLineLenght == bestLineLenght)
                        {
                            lines++;
                        }
                        if (currentLineLenght > bestLineLenght)
                        {
                            bestLineLenght = currentLineLenght;
                            lines = 1;
                        }
                    }
                    else
                    {
                        currentLineLenght = 0;
                    }
                }             
            }

            // Check cols for lines
            for (int col = 0; col < 8; col++)
            {
                currentLineLenght = 0;
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        currentLineLenght++;
                        if (currentLineLenght == bestLineLenght)
                        {
                            lines++;
                        }
                        if (currentLineLenght > bestLineLenght)
                        {
                            bestLineLenght = currentLineLenght;
                            lines = 1;
                        }
                    }
                    else
                    {
                        currentLineLenght = 0;
                    }
                }
            }

            if (bestLineLenght == 1)
            {
                lines = lines / 2;
            }
            Console.WriteLine("{0}\n{1}", bestLineLenght, lines);
        }
    }
}
