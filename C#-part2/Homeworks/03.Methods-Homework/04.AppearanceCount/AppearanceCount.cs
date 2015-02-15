using System;
using System.Collections.Generic;
using System.Globalization;

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.
class AppearanceCount
{
    static CultureInfo culture = CultureInfo.InvariantCulture; 
    static void Main()
    {
        double number = GetNumber();
        string[] inputArray = GetArray();
        FindNumber(inputArray, number);
    }

    private static void FindNumber(string[] inputArray, double number)
    {
        int count = 0;
        foreach (var item in inputArray)
        {
            if (item == number.ToString())
            {
                count++;
            }
        }
        PrintResult(count, number);
    }

    private static void PrintResult(int count, double number)
    {
        Console.WriteLine("The number {0} is present {1} times in the array", number, count);
    }

    private static string[] GetArray()
    {
        Console.WriteLine("Enter array of numbers(numbers separated by space or `,`): ");
        string[] input = Console.ReadLine().Split(new char[]{' ', ',', '\t'}, StringSplitOptions.RemoveEmptyEntries);
        return input;
    }

    private static double GetNumber()
    {
        Console.Write("Enter the number: ");
        return double.Parse(Console.ReadLine());
    }
}
