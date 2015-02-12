using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.IsThirdDigit7
{
    class CheckThirdDigit
    {
        // Write an expression that checks for given integer if its third digit from right-to-left is 7
        static void Main(string[] args)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                // Divides the input by 100, which makes the third digit last, and divides again by 10
                // Leaving the 3rd digit as a remainder and then checks if it (the remainder) is 7
                // Returns True if it's 7, False otherwise
                bool isSeven = ((input / 100) % 10 == 7);
                if (isSeven)
                {
                    Console.WriteLine("Is your third digit(right to left) seven? : {0}", isSeven);
                }
                else
                {
                    Console.WriteLine("Is your third digit(right to left) seven? : {0}", isSeven);
                    // Get the third digit as a remainder, initiqalize the thirdDigit variable with it
                    int thirdDigit = (input / 100) % 10;
                    Console.WriteLine("The third digit(right to left), of your number is: {0}", thirdDigit);
                }
            }
        }
    }
}
