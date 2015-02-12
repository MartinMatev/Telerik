using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Pillars
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];

            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = (number >> col) & 1;
                }
            }

            int pillarIndex = 7;
            int countBitsLeft = 0;
            int countBitsRight = 0;
            bool foundSolution = false;

            while (pillarIndex >= 0)
            {
                countBitsLeft = 0;
                countBitsRight = 0;

                // Почваме да броим от ляво на дясно, за да може ако намерим решение, да прекъснем while
                // Изисква се да намерим НАЙ-левия pillar, от чиито 2 страни има еднакъв брой 1 битове
                // БРОИМ 1ците по РЕДОВЕ и на всеки 8 реда местим 1 КОЛОНА !!!
                for (int col = 0; col < pillarIndex; col++)
                {
                    for (int row = 0; row < 8; row++)
                    {
                        if (matrix[row, col] == 1)
	                    {
                            countBitsLeft++;
	                    }
                    }
                }

                // След като Обходим всичко в дясно, почваме да гледаме битовете в ляво
                // Първия път няма да влезе тука, тъй като колоната pillarIndex е 7, което е максимума
                // демек най-вляво и в дясно няма нищо (извън матрицата е)
                for (int col = pillarIndex + 1; col < 8; col++)
                {
                    for (int row = 0; row < 8; row++)
                    {
                        if (matrix[row, col] == 1)
                        {
                            countBitsRight++;
                        }
                    }
                }

                if (countBitsLeft == countBitsRight)
                {
                    foundSolution = true;
                    break;
                }
                else
                {
                    pillarIndex--;
                }
            }

            if (foundSolution)
            {
                Console.WriteLine(pillarIndex);
                Console.WriteLine(countBitsLeft);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
