using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UnicodeCharacter
{
    class UnicodeChar
    {
        // Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
        static void Main(string[] args)
        {
            int number = 42;
            // cast the number to char
            char someChar = (char)number;
            Console.WriteLine("The unicode representation of the number: {0}, is {1}", number, someChar);
        }
    }
}
