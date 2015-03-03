using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Digits
{
    static int[,] matrix;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        matrix = new int[n, n];
        List<bool[,]> patterns = Patterns();

        // Fill the matrix with the imput numbers
        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = input[j];
            }
        }
        int sum = 0;
        // Check for matches
        for (int row = 0; row < n - 4; row++)
        {
            for (int col = 0; col < n - 2; col++)
            {
                // special case 1
                if (matrix[row + 2, col] == 1)
                {
                    if (CheckPattern(patterns[1], 1, row, col))
                    {
                        sum += 1;
                        continue;
                    }
                }
                // special case 2
                if (matrix[row + 1, col] == 2)
                {
                    if (CheckPattern(patterns[2], 2, row, col))
                    {
                        sum += 2;
                        continue;
                    }
                }

                int currentDigit = matrix[row, col];
                if (CheckPattern(patterns[currentDigit], currentDigit, row, col))
                {
                    sum += currentDigit;
                }
            }
        }
        Console.WriteLine(sum);
    }

    private static bool CheckPattern(bool[,] pattern, int digit, int row, int col)
    {
        for (int i = 0; i < pattern.GetLength(0); i++)
        {
            for (int j = 0; j < pattern.GetLength(1); j++)
            {
                if (pattern[i, j])
                {
                    if (matrix[row + i, col + j] != digit)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    static List<bool[,]> Patterns()
    {
        List<bool[,]> patternsList = new List<bool[,]>();

        patternsList.Add(new bool[,]
        {  
            // empty
        });
        patternsList.Add(new bool[,]
        {  
            {false, false, true},
            {false, true, true},
            {true, false, true},
            {false, false, true},
            {false, false, true},
        });
        patternsList.Add(new bool[,]
        {  
            {false, true, false},
            {true, false, true},
            {false, false, true},
            {false, true, false},
            {true, true, true}
        });
        patternsList.Add(new bool[,]
        {  
            {true, true, true},
            {false, false, true},
            {false, true, true},
            {false, false, true},
            {true, true, true}
        });
        patternsList.Add(new bool[,]
        {  
            {true, false, true},
            {true, false, true},
            {true, true, true},
            {false, false, true},
            {false, false, true}
        });
        patternsList.Add(new bool[,]
        {  
            {true, true, true},
            {true, false, false},
            {true, true, true},
            {false, false, true},
            {true, true, true}
        });
        patternsList.Add(new bool[,]
        {  
            {true, true, true},
            {true, false, false},
            {true, true, true},
            {true, false, true},
            {true, true, true}
        });
        patternsList.Add(new bool[,]
        {  
            {true, true, true},
            {false, false, true},
            {false, true, false},
            {false, true, false},
            {false, true, false}
        });
        patternsList.Add(new bool[,]
        {  
            {true, true, true},
            {true, false, true},
            {false, true, false},
            {true, false, true},
            {true, true, true}
        });
        patternsList.Add(new bool[,]
        {  
            {true, true, true},
            {true, false, true},
            {false, true, true},
            {false, false, true},
            {true, true, true}
        });

        return patternsList;
    }
}