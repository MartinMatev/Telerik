using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SubsetSums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());
            long[] nums = new long[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int maxI = (int)Math.Pow(2, n) - 1;
            int count = 0;

            for (int i = 1; i <= maxI; i++)
            {
                long currentSum = 0;
                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = i & mask;
                    int bit = iAndMask >> j;
                    if (bit == 1)
                    {
                        currentSum += nums[j];
                    }
                }
                if (currentSum == s)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
