using System;

// Write a program that generates and prints to the console 10 random values in the range [100, 200].
class RandomNumbers
{
    static void Main()
    {
        GenerateRandomNumbers();
    }

    private static void GenerateRandomNumbers()
    {
        Random randomNumber = new Random();
        for (int i = 0; i < 10; i++)
        {
            PrintResult(randomNumber.Next(100, 201), i + 1);   // first number of .Next() is inclusive, second is not, thus 201 instead fo 200
        }
    }

    private static void PrintResult(int number, int count)
    {
        Console.WriteLine("Number {0, 2}: {1}", count, number);
    }
}
