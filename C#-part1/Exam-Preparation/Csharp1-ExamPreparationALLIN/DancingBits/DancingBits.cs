using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DancingBits
{
    class DancingBits
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string binaryNum = "";

            for (int i = 0; i < n; i++)
            {
                binaryNum += Convert.ToString(int.Parse(Console.ReadLine()), 2);
            }
            int count = 0;
            int bitCount = 0;
            for (int i = 0; i < binaryNum.Length; i++)
            {
                count = 0;
                for (int j = i; j < binaryNum.Length; j++)
                {
                    if (j >= binaryNum.Length)
                    {
                        break;
                    }
                    if (binaryNum[i] == binaryNum[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > k)
                {
                    i += count - 1;
                    continue;
                }
                if (count == k)
                {
                    bitCount++;
                    i += count - 1;
                }
            }
            Console.WriteLine(bitCount);
        }
    }
}
