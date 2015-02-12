using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBall
{
    class BitBall
    {
        static void Main(string[] args)
        {
            int[,] topTeam = new int[8, 8];
            int[,] bottomTeam = new int[8, 8];

            // Input top team players
            for (int row = 0; row < 8; row++)
            {
                byte n = byte.Parse(Console.ReadLine());
                string inputNum = Convert.ToString(n, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    topTeam[row, col] = inputNum[col] - '0';
                }
            }

            // Input bottom team players
            for (int row = 0; row < 8; row++)
            {
                byte n = byte.Parse(Console.ReadLine());
                string inputNum = Convert.ToString(n, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    bottomTeam[row, col] = inputNum[col] - '0';
                }
            }

            // Check for fouls and make new gamefield
            char[,] gameField = new char[8, 8];

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (topTeam[row, col] == 1 && bottomTeam[row, col] == 1)
                    {
                        gameField[row, col] = '0';
                    }
                    else if (topTeam[row, col] == 1)
                    {
                        gameField[row, col] = 'T';
                    }
                    else if (bottomTeam[row, col] == 1)
                    {
                        gameField[row, col] = 'B';
                    }
                    else
                    {
                        gameField[row, col] = '0';
                    }
                }
            }

            // Calculate score
            int topTeamScore = 0;
            int bottomTeamScore = 0;
            int maxRow = 7;
            int minRow = 0;

            // Top team score
            for (int col = 0; col < 8; col++)
            {
                bool goalkeeper = false;
                for (int row = 0; row < 8; row++)
                {
                    if (gameField[maxRow, col] == 'T')
                    {
                        topTeamScore++;
                        break;
                    }
                    else if (gameField[row, col] == 'T')
                    {
                        for (int innerRow = row; innerRow <= maxRow; innerRow++)
                        {
                            if (gameField[innerRow, col] == 'B')
                            {
                                goalkeeper = true;
                            }
                        }

                        if (!goalkeeper)
                        {
                            topTeamScore++;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            // Bottom team score
            for (int col = 0; col < 8; col++)
            {
                bool goalkeeper = false;
                for (int row = maxRow; row >= 0; row--)
                {
                    if (gameField[minRow, col] == 'B')
                    {
                        bottomTeamScore++;
                        break;
                    }
                    else if (gameField[row, col] == 'B')
                    {
                        for (int innerRow = row; innerRow >= minRow; innerRow--)
                        {
                            if (gameField[innerRow, col] == 'T')
                            {
                                goalkeeper = true;
                            }
                        }

                        if (!goalkeeper)
                        {
                            bottomTeamScore++;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine("{0}:{1}", topTeamScore, bottomTeamScore);
        }
    }
}
