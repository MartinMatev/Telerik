using System;

/* Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	    two
1024	four
12309	nine
 */ 
class EnglishDigit
{
    static void Main()
    {
        int lastDigit = GetLastDigit();
        string word = ConvertToWord(lastDigit);
        Console.WriteLine(word);
    }

    private static string ConvertToWord(int lastDigit)
    {
        switch (lastDigit)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return "zero";
        }
    }

    private static int GetLastDigit()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        return number % 10;
    }
}
