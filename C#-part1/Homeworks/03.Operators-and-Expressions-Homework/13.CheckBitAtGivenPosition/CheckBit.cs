using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitAtGivenPosition
{
    class CheckBit
    {
        // Write a Boolean expression that returns if the bit at position p 
        // (counting from 0, starting from the right) in given integer number n, has value of 1
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type in your number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Type in the position of the bit: ");
                int position = int.Parse(Console.ReadLine());
                // Takes the bit at the given position and moves it all the way back
                // Bitwise & compares it to 1 (000...00001).Returns true if it is 1.
                bool isOne = ((number >> position) & 1) == 1;
                Console.WriteLine(isOne);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
        }
    }
}
