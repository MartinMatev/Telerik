using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BinaryDigitCount
{
    class BinaryDigitCount
    {
        static void Main(string[] args)
        {
            //Version 1 : Hurr, Durr I am retarded
            /*
            byte b = byte.Parse(Console.ReadLine());
            short n = short.Parse(Console.ReadLine());
            uint[] nums = new uint[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = uint.Parse(Console.ReadLine());
            }
            int count = 0;
            foreach (var digit in nums)
            {
                count = 0;
                string binaryForm = Convert.ToString(digit, 2);
                for (int i = 0; i < binaryForm.Length; i++)
                {
                    int binaryNum = (int)Char.GetNumericValue(binaryForm[i]);
                    if (binaryNum == b)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
             */ 
            
            //Version 2:
            byte b = byte.Parse(Console.ReadLine());
            short n = short.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                uint number = uint.Parse(Console.ReadLine());

                while (number != 0)
                {
                    if ((number & 1) == b)
                    {
                        count++;
                    }
                    number = number >> 1;
                }
                Console.WriteLine(count);
            }
        }
    }
}
