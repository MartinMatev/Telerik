using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation
namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 999: ");
            int number;
            string numberInWords = "";

            if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 999)
            {
                string[] belowTwenty = { "Zero" , "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", 
                                           "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
                string[] aboveTwenty = { "", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                int remainder = number % 10;
                bool isNotZero = remainder != 0; 
                int hundreds = number / 100;

                // If the number is below twenty, search for it in the first array, by passing the numbers as a element indicator
                if (number < 19)
                {
                    numberInWords += belowTwenty[number];
                    Console.WriteLine("Your number is: {0}", numberInWords);
                }
                else if (number >= 20 && number <= 99)
                {
                    // is its between 20 and 99, divide it by ten to get the frist digit, and use it to search through the aboveTwenty array for the appropriate translation
                    number /= 10;
                    numberInWords += aboveTwenty[number] + " ";
                    // If the second digit of the number is NOT 0, then use the remainder of the division by 10 to get the second digit in words
                    if (isNotZero)
                    {
                        numberInWords += belowTwenty[remainder].ToLower();
                    }
                    Console.WriteLine("Your number is: {0}", numberInWords);
                }
                else
                {
                    int tempNumber = number;
                    number /= 10;
                    int tens = number % 10;
                    numberInWords += belowTwenty[hundreds] + " hundred ";
                    // Check if the tens are 1. In that case, divide the number by 100 and assign the tens variable the remainder. Ex: 519 % 100 = 0.19 as a remainder
                    if (tens == 1)
                    {
                        tens = tempNumber % 100;
                        numberInWords += "and " + belowTwenty[tens].ToLower() + " ";
                    }
                    else if (tens == 0 && !isNotZero)
                    {
                        // If both the tens and the last digit are 0, get in here to skip display the last digit in words. I.e 500 = five hundred, not five hundred and zero
                        numberInWords += aboveTwenty[tens].ToLower() + " ";
                    }
                    else
                    {
                        // assigning the tens meaning in words, if its anything but 1 and 0
                        numberInWords += "and "+aboveTwenty[tens].ToLower() + " ";
                        // If the last digit is NOT 0, then search for its wording in the below twenty array
                        if (isNotZero)
                        {
                            numberInWords += belowTwenty[remainder].ToLower();
                        }
                    }
                    Console.WriteLine("Your number is: {0}", numberInWords);
                }
            }
        }
    }
}
