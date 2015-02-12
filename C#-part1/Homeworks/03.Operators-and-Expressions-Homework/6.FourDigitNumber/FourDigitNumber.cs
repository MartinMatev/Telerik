using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FourDigitNumber
{
    class FourDigitNumber
    {
        // Write a program that takes as input a four-digit number in format abcd (e.g. 2011) 
        // and performs the following:
        // - Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        // - Prints on the console the number in reversed order: dcba (in our example 1102).
        // - Puts the last digit in the first position: dabc (in our example 1201).
        // - Exchanges the second and the third digits: acbd (in our example 2101).
        // !! The number has always exactly 4 digits and cannot start with 0.

        static void Main(string[] args)
        {
            int input;
            Console.Write("Enter a 4 digit number: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if ((input / 1000) != 0 && (input / 1000) < 9)
                {
                    // VERSION 1:

                    // Calculate the sum of the digits
                    int firstDigit = (input / 1000) % 10;
                    int secondDigit = (input / 100) % 10;
                    int thirdDigit = (input / 10) % 10;
                    int fourthDigit = input % 10;
                    int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
                    Console.Write("The sum of the digits of the number {0}, is: {1}\n", input, sum);
                    // Prints on the console the number in reversed order
                    Console.Write("Reversed order: ");
                    Console.WriteLine(fourthDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + firstDigit.ToString());
                    // Puts the last digit in the first position
                    Console.Write("Last digit in first position: ");
                    Console.WriteLine(firstDigit.ToString() + secondDigit.ToString() + thirdDigit.ToString() + fourthDigit.ToString());
                    // Exchanges the second and the third digits: acbd (in our example 2101).
                    Console.Write("Exchange second and third position: ");
                    Console.WriteLine(firstDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + fourthDigit.ToString());
                    
                    
                    // VERSION 2:
                    /*
                    int sumResult = DigitSum(input);
                    Console.WriteLine("The sum of the digits of the number {0}, is: {1}", input, sumResult);

                    int reversedResult = ReversedOrder(input);
                    Console.WriteLine("Reversed: {0}", reversedResult);

                    bool firstToLast = true;
                    int swapResult = LastDigitFirst(input, firstToLast);
                    Console.WriteLine("Frist and Last digit swap: {0}", swapResult);

                    firstToLast = false;
                    swapResult = LastDigitFirst(input, firstToLast);
                    Console.WriteLine("Second and third digit swap: {0}", swapResult);
                     */ 
                }
                else
                {
                    Console.WriteLine("Please enter a 4 digit number, that doesn't start with 0!");
                }
            }
            else
            {
                Console.WriteLine("An integer is required!");
            }
        }
        // Gets called with the input number, returns calculated sum of it's digits
        static int DigitSum (int input)
        {
            int sum = 0;
            int temp = input;
            for (int i = 0; i < 4; i++)
            {
                sum += temp % 10;
                temp /= 10;
            }
            return sum;
        }
        //BELOW are functions used by the SECOND Version !!!

        // Gest called with the input num, returns reveres number
        static int ReversedOrder (int input)
        {
            string inputString = input.ToString();
            int reversed = 0;
            int temp = input;
            for (int i = 0; i < 4; i++)
            {
                int remainder = temp % 10;
                reversed = (reversed * 10) + remainder;
                temp /= 10;
            }
            return reversed;
        }
        // Gets called with the input num and bool to decide which digits to swap, returns swaped number
        static int LastDigitFirst(int input, bool firstToLast)
        {
            int swapResult;
            string firstDigit = ((input / 1000) % 10).ToString();
            string secondDigit = ((input / 100) % 10).ToString();
            string thirdDigit = ((input / 10) % 10).ToString();
            string fourthDigit = (input % 10).ToString();
            if (firstToLast)
            {
                swapResult = Convert.ToInt32(fourthDigit + secondDigit + thirdDigit + firstDigit);
            }
            else
            {
                swapResult = Convert.ToInt32(firstDigit + thirdDigit + secondDigit + fourthDigit);
            }
            return swapResult;
        }
    }
}
