using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggcelent
{
    class Eggcelent
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n;
            int width = 3 * n - 1;
            int drawingWidth = 3 * n + 1;
            int eggTop = n - 1;
            int eggBottom = n - 1;
            char crack = '@';
            char shell = '*';
            char dot = '.';
            int count = 0;
            int temporaryN = n;

            // Top
            Console.Write(dot);
            Console.Write(new string(dot, n));
            Console.Write(new string(shell, eggTop));
            Console.Write(new string(dot, n));
            Console.WriteLine(dot);

            // Printing the upper slope
            for (int i = 0; i < n - 2; i++)
            {
                count = temporaryN - 2;
                if (count < 1)
                {
                    break;
                }
                Console.Write(dot);
                Console.Write(new string(dot, count));
                Console.Write(shell);
                Console.Write(new string (dot, width - temporaryN * 2 + 2));
                Console.Write(shell);
                Console.Write(new string(dot, count));
                Console.Write(dot);

                Console.WriteLine();
                temporaryN -= 2;
            }
            
            // After slope (before crack...cocaine)
            for (int i = 1; i < n / 2; i++)
            {
                Console.Write(dot);
                Console.Write(shell);
                Console.Write(new string(dot, width - 2));
                Console.Write(shell);
                Console.Write(dot);
                Console.WriteLine();
            }

            // Crack-hoe
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            sb1.Append(dot);
            sb1.Append(shell);
            sb2.Append(dot);
            sb2.Append(shell);
            for (int i = 0; i < width - 2; i++)
            {
                if (i % 2 == 0)
                {
                    sb1.Append(crack);
                    sb2.Append(dot);
                }
                else
                {
                    sb1.Append(dot);
                    sb2.Append(crack);
                }
            }
            sb1.Append(shell);
            sb1.Append(dot);
            sb2.Append(shell);
            sb2.Append(dot);
            Console.WriteLine(sb1.ToString());
            Console.WriteLine(sb2.ToString());

            // Before Slope
            for (int i = 1; i < n / 2; i++)
            {
                Console.Write(dot);
                Console.Write(shell);
                Console.Write(new string(dot, width - 2));
                Console.Write(shell);
                Console.Write(dot);
                Console.WriteLine();
            }

            // Printing the downwards slope
            int bottomCounter = 0;
            for (int i = 0; i < n - (n / 2); i++)
            {
                bottomCounter += 2;
                if (bottomCounter == n)
                {
                    break;
                }
                Console.Write(dot);
                Console.Write(new string(dot, bottomCounter));
                Console.Write(shell);
                Console.Write(new string(dot, width - bottomCounter * 2 - 2));
                Console.Write(shell);
                Console.Write(new string(dot, bottomCounter));
                Console.Write(dot);

                Console.WriteLine();
            }

            // Bottom
            Console.Write(dot);
            Console.Write(new string(dot, n));
            Console.Write(new string(shell, eggBottom));
            Console.Write(new string(dot, n));
            Console.WriteLine(dot);
        }
    }
}
