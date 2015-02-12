using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBits
{
    class AngryBits
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 16];

            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int col = 0; col < 16; col++)
                {
                    int bit = (number >> col) & 1;
                    matrix[row, col] = bit;
                }
            }

            int score = 0;
            // Започваме от първата колона с пилета (8) и вървим към последната (15)
            for (int col = 8; col < 16; col++)
            {
                int currentRow = -1;
                // Въртим всеки ред на една колона и търсим 1ци
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        currentRow = row;
                        break;
                    }
                }
                // Game logic - killing pigs (the break in the IF gets us here)
                // Ако не сме намерили птица, бием -1 на текущия ред и отиваме на следващата
                if (currentRow == -1)
                {
                    continue;
                }
                else
                {
                    // Симулираме изкачване напред по диагонала ако имаме птица
                    // Изтрелваме я нагоре докато не удари тавана и почва да пада към прасетата, пак диагонално
                    int path = 0; // Изминат път
                    int pigsHitted = 0;

                    string direction = "up";
                    matrix[currentRow, col] = 0;

                    for (int currentColumn = col; currentColumn >= 0; currentColumn--)
                    {
                        if (direction == "up")
                        {
                            currentRow--;
                            // Ако сме стигнали върха, сменяме посоката на долу, понеже вече сме извън нея
                            // увеличаваме с ++ за да се върнем на 0-левия ред
                            if (currentRow == -1)
                            {
                                currentRow++;
                                direction = "down";
                            }
                        }
                        else
                        {
                            currentRow++;
                            if (currentRow > 7)
                            {
                                break;
                            }
                        }

                        if (matrix[currentRow, currentColumn] == 1)
                        {
                            path = col - currentColumn;

                            // ЦИкъл за обхождане на клетките около удареното прасе, за да убием и приятелите му
                            for (int i = currentRow - 1; i <= currentRow + 1; i++)
                            {
                                for (int j = currentColumn - 1; j <= currentColumn + 1; j++)
                                {
                                    // Проверка дали сме вътре в масива, да не излезем от него докато
                                    // търсим околни прасета
                                    if (i > -1 && i < 8 && j > -1)
                                    {
                                        if (matrix[i, j] == 1)
                                        {
                                            pigsHitted++;
                                            // Зануляваме ударените прасета
                                            matrix[i, j] = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    score = score + pigsHitted * path;
                }
            }
            string result = "Yes";

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        result = "No";
                        break;
                    }
                }
            }
            Console.WriteLine("{0} {1}", score, result);
        }
    }
}
