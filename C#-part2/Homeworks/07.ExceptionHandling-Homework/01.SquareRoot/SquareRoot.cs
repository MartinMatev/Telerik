using System;

/*
 * Write a program that reads an integer number and calculates and prints its square root.
 * If the number is invalid or negative, print Invalid number.
 * In all cases finally print Good bye.
 * Use try-catch-finally block.
 */
class SquareRoot
{
    static void Main()
    {
        try
        {
            int number = GetNumber();
            Console.WriteLine(number);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
        
    }

    private static int GetNumber()
    {
        Console.Write("Enter non-negative integer number: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            throw new ArgumentException();
        }
        return (int)Math.Pow(number, 2);
    }
}
