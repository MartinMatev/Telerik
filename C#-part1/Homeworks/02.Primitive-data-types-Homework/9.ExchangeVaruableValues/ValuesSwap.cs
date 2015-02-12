using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExchangeVaruableValues
{
    class ValuesSwap
    {
        // Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
        // Print the variable values before and after the exchange.
        static void Main(string[] args)
        {
            // Ver.1 NO temporary variable (not a good idea overall)
            int a = 5;
            int b = 10;

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The value of \"a\" is: {0}, and the value of \"b\" is {1}", a, b);

            // Ver.2 WITH temporary variable (comment the upper version before running this one !)

            //int temp;
            //temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("The value of \"a\" is: {0}, and the value of \"b\" is {1}", a, b);
        }
    }
}
