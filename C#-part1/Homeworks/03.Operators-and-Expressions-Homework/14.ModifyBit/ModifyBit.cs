using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyBit
{
    class ModifyBit
    {
        // We are given an integer number n, a bit value v (v=0 or 1) and a position p.
        // Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
        // from the binary representation of n while preserving all other bits in n.
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type in your number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Type in the position of the bit: ");
                int position = int.Parse(Console.ReadLine());

                Console.Write("Type in the new value of the bit (0 or 1): ");
                int value = int.Parse(Console.ReadLine());
                int modifiedNum;

                if (value == 0)
                {
                    // Make a mask with a guaranteed 0 at the required position
                    int mask = ~(1 << position);
                    // Bitwise & the mask and our number, so the only modified bit (to 0) is at the given position
                    modifiedNum = number & mask;
                    Console.WriteLine(modifiedNum);
                }
                else if (value == 1)
                {
                    int mask = 1 << position;
                    modifiedNum = number | mask;
                    Console.WriteLine(modifiedNum);
                }
                else
                {
                    Console.WriteLine("Value can only be 1 or 0.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
        }
    }
}
