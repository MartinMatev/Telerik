using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Quotation
{
    class StringQuotes
    {
        // Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
        // Do the above in two different ways - with and without using quoted strings.
        // Print the variables to ensure that their value was correctly defined.
        static void Main(string[] args)
        {
            string quotedString = @"The ""use"" of quotations causes difficulties.";
            string escapedString = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine("With quotation: {0} \nand using escape technique: {1}", quotedString, escapedString);
        }
    }
}
