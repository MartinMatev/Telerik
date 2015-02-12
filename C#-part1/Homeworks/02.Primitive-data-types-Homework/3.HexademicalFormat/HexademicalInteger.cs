using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HexademicalFormat
{
    class HexademicalInteger
    {
        // Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
        // Use Windows Calculator to find its hexadecimal representation.
        // Print the variable and ensure that the result is 254.
        static void Main(string[] args)
        {
            int number = 254;
            Console.WriteLine("The hexademical format of the number: {0}, is: {0:X}", number);
        }
    }
}
