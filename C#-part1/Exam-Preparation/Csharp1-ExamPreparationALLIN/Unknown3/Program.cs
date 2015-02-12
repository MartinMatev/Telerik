using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown3
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int transformationCount = 0;
            ulong evenSum = 0;
            ulong product = 1;

            while (transformationCount < 10)
            {

                do
                {
                    number /= 10;
                    if (number <= 0)
                    {
                        break;
                    }
                    string numberStr = number.ToString();
                    evenSum = 0;
                    for (int i = 0; i < numberStr.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            evenSum += (ulong)(numberStr[i] - '0');
                        }
                    }
                    product *= evenSum;
                }
                while (number > 0);
                transformationCount++;

                if (product >= 0 && product <= 9 && transformationCount < 10)
                {
                    Console.WriteLine(transformationCount);
                    Console.WriteLine(product);
                    return;
                }
                else
                {
                    number = product;
                    product = 1;
                }
            }
            Console.WriteLine(number);
        }
    }
}
