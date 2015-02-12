using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets2
{
    class Carpets2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n; 
            int height = n;
            char dot = '.';
            char blank = ' ';
            char slashNormal = '/';
            char slashEscape = '\\';

            //Top of Carpet
            int tempDotLenght = n / 2 - 1;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.Write(new string(dot, tempDotLenght));
                Console.Write(new string(slashNormal, i + 1));
                //if (i % 2 != 0)
                //{
                //    //Console.Write(new string(blank, 2));  
                //}
                Console.Write(new string(slashEscape, i + 1));
                Console.Write(new string(dot, tempDotLenght));

                Console.WriteLine();
                tempDotLenght--;
            }

            // Upper and Lower Middle of the Carpet

            for (int row = 1; row <= 2; row++)
            {
                for (int col = 0; col < width / 2; col++)
                {
                    if (row == 1)
                    {
                        if (col < width / 4)
                        {
                            Console.Write(slashNormal);
                            Console.Write(blank);
                        }
                        else
                        {
                            Console.Write(slashEscape);
                            Console.Write(blank);
                        }
                    }
                    else
                    {
                        if (col < width / 2)
                        {
                            Console.Write(slashEscape);
                            Console.Write(blank);
                        }
                        else
                        {
                            Console.Write(slashNormal);
                            Console.Write(blank);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
