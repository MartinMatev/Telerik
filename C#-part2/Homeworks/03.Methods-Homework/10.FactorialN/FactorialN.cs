using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

// Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
class FactorialN
{
    static void Main()
    {
        byte number = GetNumber();
        if (ValidateNumber(number))
        {
            CalculateFactorial(number);
        }
    }

    private static void CalculateFactorial(byte length)
    {
        int [] factorialArray = new int[]{1};

        for (int i = 1; i <= length; i++)
        {
            factorialArray = Multiplication(factorialArray, i);
        }

        PrintResult(factorialArray, length);
    }

    private static void PrintResult(int[] factorialArray, int number)
    {
        Console.WriteLine("The factorial of {0} is:", number);
        foreach (var item in factorialArray)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

    private static int[] Multiplication(int[] factorialArray, int currentNum)
    { 
        BigInteger tempContainer = 0;
        // Contains the value of tempContainer, chopped digit by digit
        List<int> choppedContainer = new List<int>();
        int length = factorialArray.Length;

        for (int i = 0; i < length; i++)
        {
            tempContainer += factorialArray[i] * (BigInteger)Math.Pow(10, length - i - 1);
        }

        tempContainer *= currentNum;

        // Chop the bigint tempContainer and initialize the list with each of its digits
        for (BigInteger i = tempContainer; i > 0; i/= 10)
        {
            choppedContainer.Add((int)(i % 10));
        }

        // Turn the list to an array, because CalculateFactorial assigns the return value to an ARRAY, not LIST
        choppedContainer.Reverse();
        return choppedContainer.ToArray();

    }

    private static void PrintResult(BigInteger[] array, int factorialOf)
    {
        Console.WriteLine(string.Join("", array));
        //Console.WriteLine("The factorial of {0} is: {1}", factorialOf, factorial);
    }

    private static bool ValidateNumber(byte number)
    {
        return number >= 1 && number <= 100;
    }

    private static byte GetNumber()
    {
        Console.Write("Enter number in the range of [1..100]: ");
        return byte.Parse(Console.ReadLine());
    }
}
