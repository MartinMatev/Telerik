using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
        static void Main(string[] args)
        {
            Console.Write("Type in the number: ");
            uint number;
            if (uint.TryParse(Console.ReadLine(), out number))
            {
                int firstMask;
                int secondMask;
                // Loops through the frist required bits (3, 4, 5) -- Loops only once for each bit !
                for (int posFirst = 3; posFirst <= 5; posFirst++)
                {
                    // loops through the second required bits (24, 25, 26) -- Loops only once for each bit !
                    for (int posSecond = posFirst + 21; posSecond <= posFirst + 21; posSecond++)
                    {
                        // Move number's digit on position posFirst (3, then 4, then 5) to the right
                        // and bitwise & compare it ot 1 (00...0001) 
                        uint firstTempNumber = (number >> posFirst) & 1;
                        // Move number's digit on position posSecond (24, then 25, then 26) to the right 
                        // and bitwise & compare it ot 1 (00...0001)
                        uint secondTempNumber = (number >> posSecond) & 1;

                        // An if statement, so we can change bits 3-24, 4-25 or 5-26 ONLY if thry are different
                        if (firstTempNumber != secondTempNumber)
                        {
                            // Create a mask and move the last bit of the num 1 (which is 1) on the posFirst(3, then 4, then 5th) position
                            firstMask = 1 << posFirst;
                            // Create a mask and move the last bit of the num 1 (which is 1) on the posSecond(24, then 25, then 26th) position
                            secondMask = 1 << posSecond;

                            // Bitwse XOR the number and the mask, initializing number with the result 
                            number = number ^ (uint)firstMask;
                            number = number ^ (uint)secondMask;
                        }
                    }
                }
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Our of range or wrong format!");
            }
        }
    }
}
