using System;
using System.Linq;

/*
 * Write a program that can solve these tasks:
 * 
 * Reverses the digits of a number
 * Calculates the average of a sequence of integers
 * Solves a linear equation a * x + b = 0
 * 
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 * 
 * The decimal number should be non-negative
 * The sequence should not be empty
 * a should not be equal to 0
 */

class SolveTasks
{
    static void Main()
    {
        ConsoleKeyInfo pressedKey = ChooseOperation();

        do{
            Console.ReadLine();
            if (pressedKey.Key == ConsoleKey.D1)
            {
                decimal number = GetNumberToReverse();
                if (number == -1)
                {
                    Console.WriteLine("Wrong data format!");
                    return;
                }
                ReverseDigits(number);          
            }
            else if (pressedKey.Key == ConsoleKey.D2)
            {
                int[] sequence = GetSequence();
                if (sequence.Length == 0)
                {
                    Console.WriteLine("Sequence means atleast 1.");
                    return;
                }
                CalculateAvarage(sequence);
            }
            else if (pressedKey.Key == ConsoleKey.D3)
            {
                GetEquation();
            }

            if (pressedKey.Key != ConsoleKey.Escape)    
                pressedKey = ChooseOperation();
        }
        while (pressedKey.Key != ConsoleKey.Escape);
        Console.WriteLine("K, bye.");
    }

    private static void GetEquation()
    {
        decimal a;
        do 
        {
            Console.Write("Type in non-zero A: ");
            a = decimal.Parse(Console.ReadLine());
        }
        while (a == 0);

        Console.Write("Type in B: ");
        decimal b = decimal.Parse(Console.ReadLine());
        PrintResult(-b / a, "Equation x = -b / a");
    }

    private static void CalculateAvarage(int[] sequence)
    {
        PrintResult((sequence.Sum() / (decimal)sequence.Length), "Average");
    }

    private static int[] GetSequence()
    {
        Console.WriteLine("Type in sequence of INTS, separated by comma or space");
        Console.Write(">>");
        return Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(x => int.Parse(x))
                                 .ToArray();
    }

    private static void ReverseDigits(decimal number)
    {
        string str = number.ToString();
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        str = new string(charArray);

        PrintResult(decimal.Parse(str), "Reversed");
    }

    private static void PrintResult(decimal number, string from)
    {
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("{0} result = {1}", from, number);
        Console.WriteLine(new string('-', 30));
    }

    private static decimal GetNumberToReverse()
    {
        decimal number;
        Console.Write("Type in non-negative number to reverse:");
        if (decimal.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            return number;
        }
        return -1;
    }

    private static ConsoleKeyInfo ChooseOperation()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the most useful software ever.");
        Console.WriteLine("Please type in the key (1, 2 or 3) depending on the operation you want done.");
        Console.WriteLine();
        Console.WriteLine("[1] Reversing the digits of a number");
        Console.WriteLine("[2] Calculation of avarage of a sequence of integers");
        Console.WriteLine("[3] Solving linear equation {a * x + b = 0}");
        Console.WriteLine("[ESCAPE] I die a little inside everytime you press this");
        return Console.ReadKey();
    }
}
