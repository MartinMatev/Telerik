using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightmareOnCodestreet
{
    class NightmareOnCodestreet
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            char[] numberList = number.ToCharArray();
            int actualLength = numberList.Length;
            long sum = 0;
            int count = 0;

            if (numberList[0] - '0' < 0)
            {
                for (int i = 0; i < numberList.Length - 1; i++)
                {
                    numberList[i] = numberList[i + 1];
                }
                actualLength--;
            }

            for (int i = 0; i < actualLength; i++)
            {
                if ((i  + 1) % 2 == 0)
                {
                    if (Char.IsDigit(numberList[i]))
                    {
                        sum += (numberList[i] - '0');
                        count++;
                    }
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
        }
    }
}
