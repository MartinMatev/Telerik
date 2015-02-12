using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDownVer3_ArrayOnly
{
    class FallDownArrayOnly
    {
        static void Main(string[] args)
        {
            // Input
            int[,] matrix = new int[8, 8];
            for (int row = 0; row < 8; row++)
            {
                int num = int.Parse(Console.ReadLine());
                string numToString = Convert.ToString(num, 2).PadLeft(8, '0');

                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = int.Parse(numToString[col].ToString());
                }
                //Console.WriteLine();
            }
            for (int col = 0; col < 8; col++)
            {
                int count = 0;
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        count++;
                        matrix[row, col] = 0;
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    matrix[7 - i, col] = 1;
                }
            }


            //for (int row = 0; row < 8; row++)
            //{
            //    for (int col = 0; col < 8; col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // Output
            for (int row = 0; row < 8; row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < 8; col++)
                {
                    sb.Append(matrix[row, col]);
                }

                int num = Convert.ToInt32(sb.ToString(), 2);
                Console.WriteLine(num);
            }
        }
    }
}
