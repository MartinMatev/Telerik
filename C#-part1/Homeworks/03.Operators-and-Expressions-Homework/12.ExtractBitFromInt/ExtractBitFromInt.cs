using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInt
{
    class ExtractBitFromInt
    {
        // Write an expression that extracts from given integer n the value of given bit at index p.
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type in your number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Type in the position of the bit you want extracted: ");
                int position = int.Parse(Console.ReadLine());
                // Takes the bit at the given position from the number and moves it all the way back
                // Bitwise & compares it to 1 (00..00001) and initializes the bit variable with the result
                int bit = (number >> position) & 1;
                Console.WriteLine("The bit at position {0} of number {1} is : {2}", position, number, bit);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
        }
    }
}
