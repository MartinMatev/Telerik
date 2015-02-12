using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAllLoveBits
{
    class WeAllLoveBits
    {
        static void Main(string[] args)
        {
            /*
            int n = int.Parse(Console.ReadLine());
            List<string> numbers = new List<string>();
            int currentNumber = 0;
            int invertedNumber = 0;
            int reversedNumber = 0;
            int magicalNumber = 0;
            string binaryNumber;
            string magicalString;

            for (int i = 0; i < n; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                invertedNumber = ~currentNumber;
                binaryNumber = Convert.ToString(currentNumber, 2);

                char[] charArray = binaryNumber.ToCharArray();
                Array.Reverse(charArray);
                binaryNumber = new string(charArray);
                reversedNumber = Convert.ToInt32(binaryNumber);

                magicalNumber = (currentNumber ^ invertedNumber) & reversedNumber;
                magicalString = magicalNumber.ToString();
                magicalString = Convert.ToInt32(magicalString, 2).ToString();
                numbers.Add(magicalString);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        */
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int bits = int.Parse(Console.ReadLine());
                int result = 0;
                while (bits > 0)
                {
                    int lastBit = bits & 1;
                    result = result << 1;
                    result = result ^ lastBit;
                    bits = bits >> 1;
                }
                Console.WriteLine(result);
            }
        }
    }
}
