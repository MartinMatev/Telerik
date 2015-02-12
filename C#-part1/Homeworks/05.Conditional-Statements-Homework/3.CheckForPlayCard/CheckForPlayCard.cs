using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
// Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise
namespace _3.CheckForPlayCard
{
    class CheckForPlayCard
    {
        static void Main(string[] args)
        {
            // Initialize a string array with all the possible card faces
            string[] cardSigns = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            Console.Write("Enter string to check: ");
            string input = Console.ReadLine();
            bool match = false;

            for (int i = 0; i < cardSigns.Length; i++)
            {
                // Check if theres a match, change the match boolean to true, so we skip the "No" writeline, print out "Yes" and break early of the cycle
                if (input == cardSigns[i])
                {
                    Console.WriteLine("Yes");
                    match = true;
                    break;
                }
            }
            if (!match)
            {
                Console.WriteLine("No");
            }
        }
    }
}
