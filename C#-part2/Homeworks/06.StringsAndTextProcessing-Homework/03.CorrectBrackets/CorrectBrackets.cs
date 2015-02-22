using System;

/*
 * Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d). 
 * Example of incorrect expression: )(a+b)).
 */
class CorrectBrackets
{
    static void Main()
    {
        string input = ReadInput();
        bool isCorrect = BracketsCheck(input);
        Console.WriteLine("Your expression is: {0}", isCorrect ? "correct" : "incorrect");
    }

    private static bool BracketsCheck(string input)
    {
        int leftBracketCounter = 0;
        int rightBracketCounter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            // If the first element is a closing bracket or the last one is an opening one, it's incorrect
            if (input[0] == ')' || input[input.Length - 1] == '(')
            {
                return false;
            }
            if (input[i] == '(')
            {
                leftBracketCounter++;
            }
            else if (input[i] == ')')
            {
                rightBracketCounter++;
            }
        }

        if (rightBracketCounter != leftBracketCounter)
        {
            return false;
        }
        return true;
    }

    private static string ReadInput()
    {
        Console.Write("Enter expression: ");
        return Console.ReadLine();
    }
}