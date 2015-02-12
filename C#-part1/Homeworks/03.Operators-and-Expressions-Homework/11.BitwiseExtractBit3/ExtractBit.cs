using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BitwiseExtractBit3
{
    class ExtractBit
    {
        // Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
        // The bits are counted from right to left, starting from bit #0.
        // The result of the expression should be either 1 or 0.
        static void Main(string[] args)
        {
            uint number;
            Console.Write("Type in the unsigned integer: ");
            if (uint.TryParse(Console.ReadLine(), out number))
            {
                int position = 3;
                // Move the bits before the 3rd one (0, 1 and 2) to the left, so the last one becomes the 3rd 
                uint numRightPos = number >> position;
                // Returns 1 ONLY if both last bits are 1, 0 in every other case 
                uint bit = numRightPos & 1;
                Console.WriteLine("{0}'s third is: {1}", number, bit);
            }
        }
    }
}
