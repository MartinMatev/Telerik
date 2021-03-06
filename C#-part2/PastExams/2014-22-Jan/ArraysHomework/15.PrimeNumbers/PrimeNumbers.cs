﻿using System;

// Write a program that finds all prime numbers in the range [1...10 000 000]. 
// Use the Sieve of Eratosthenes algorithm.
class PrimeNumbers
{
    static void Main()
    {
        int length = 10000000;
        bool[] numbersArray = new bool[length];

        // a loop to mark all the 10 000 000 values of the array, except 0 and 1, as TRUE 
        for (int i = 2; i < length; i++)
        {
            numbersArray[i] = true;
        }
        // Loop the boolean array from 2 up to 10 000 000
        for (int i = 2; i < length; i++)
        {
            // If the i element of the array is set to true, enter the second loop
            if (numbersArray[i] == true)
            {
                for (int j = 2; (i * j) < length; j++)
                {
                    // set EVERY multiple of "i" to false (2, 4, 6...etc on the first entry)
                    // (3, 9, 12, 15...etc on the second one), (5, 10, 15, 20 etc on the third one up until 7)
                    numbersArray[i * j] = false;
                }
            }
        }
        // The ELEMENTS that remain TRUE after all this ARE prime numbers.

        // Displaying the numbers--- WARNING there are A LOT of primes up until 10 000 000.
        // Displaying them is problematic, because of the buffer size && WriteLine is kinda slow. Use at your own risk.
        // You may try it with a lower number - 10000; If you want to test it with 10 000 000, type in length (or just 10 000 000) in the FOR cycle below, instead of 10 000

        for (int i = 0; i < 10000; i++)
        {
            if (numbersArray[i] == true)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
