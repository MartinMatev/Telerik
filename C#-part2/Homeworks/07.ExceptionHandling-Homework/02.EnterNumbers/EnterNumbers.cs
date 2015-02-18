using System;

/*
 * Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
 * If an invalid number or non-number text is entered, the method should throw an exception.
 * Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */
class EnterNumbers
{
    static int start = 1;
    static int end = 100;
    static int count = 10;
    static void Main()
    {
        try
        {
            ReadNumber(start, end);
        }
        catch(FormatException)
        {
            Console.WriteLine("Please use the correct format.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number must be >= {0} && <= {1} and < than the previous number.", start, end);
        }

    }

    private static void ReadNumber(int start, int end)
    {
        int inputNumber = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter number {0}/{1}: ", i + 1, count);
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber < start || inputNumber > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            start = inputNumber;
        }
    }
}