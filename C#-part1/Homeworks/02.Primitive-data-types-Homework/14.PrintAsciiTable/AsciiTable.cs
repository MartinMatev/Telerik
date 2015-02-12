using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintAsciiTable
{
    class AsciiTable
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int column = 0;

            // Loop through the ascii table values and display them one by one
            for (byte i = 0; i < 255; i++)
            {
                column++;
                Console.Write(" {0}  ", (char)i);

                // If the column counter reaches 7 columns, reset it and put a new line.
                // Some symbols break the column display by using foul magic, dont mind it.  
                if (column > 15)
                {
                    column = 0;
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine();
        }
    }
}
