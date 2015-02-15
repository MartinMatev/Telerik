using System;

// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
class GetLargestNumber
{
    static void Main(string[] args)
    {
        int firstNum = GetInteger("one");
        int secondNum = GetInteger("two");
        int thirdNum = GetInteger("three");        
        int biggestNum = GetMax(GetMax(firstNum, secondNum), thirdNum);

        Console.WriteLine("The biggest of them all is: {0}", biggestNum);
    }

    private static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum >= secondNum)
        {
            return firstNum;
        }
        return secondNum;
    }

    private static int GetInteger(string num)
    {
        Console.Write("Enter integer {0}: ", num);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
}
