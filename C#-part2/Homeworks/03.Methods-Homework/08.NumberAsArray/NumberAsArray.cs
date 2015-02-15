using System;
using System.Linq;

/*
 * Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.
 */ 
class NumberAsArray
{
    static void Main()
    {
        string numberOne = GetNumber("first");
        string numberTwo = GetNumber("second");
        CalculateSum(numberOne, numberTwo);
    }

    private static void CalculateSum(string numberOne, string numberTwo)
    {
        int length = Math.Max(numberOne.Length, numberTwo.Length);
        int[] result = new int[length];
        var firstNumArray = numberOne.Select(ch => ch - '0').ToArray();
        var secondNumArray = numberTwo.Select(ch => ch - '0').ToArray();
        int remainder = 0;

        for (int i = 0; i < length; i++)
        {
            // A necessary check, needed because one number (array's length) can be less than the other so we need to assign 0s.
            int arrayOneNum = i < numberOne.Length ? firstNumArray[i] : 0;
            int arrayTwoNum = i < numberTwo.Length ? secondNumArray[i] : 0;

            int currentNumber = (arrayOneNum + arrayTwoNum) + remainder;
            remainder = currentNumber / 10;
            currentNumber %= 10;
            result[i] = currentNumber;
                     
        }
        Array.Reverse(result);
        PrintResult(result);
    }

    private static void PrintResult(int[] result)
    {
        Console.WriteLine("The sum of your numbers is:");
        foreach (var item in result)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

    private static string GetNumber(string p)
    {
        Console.WriteLine("Type in {0} number below:", p);
        Console.Write(">");

        char[] number = Console.ReadLine().Trim('-').ToCharArray();
        Array.Reverse(number);
        return (new string(number).Replace(" ", string.Empty));
    }
}
