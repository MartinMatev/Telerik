using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SevenSegmentDisplay
{
    static readonly byte[] digits = new byte[10]
    {
        Convert.ToByte("1111110", 2), // 0
        Convert.ToByte("0110000", 2), // 1
        Convert.ToByte("1101101", 2), // 2
        Convert.ToByte("1111001", 2), // 3
        Convert.ToByte("0110011", 2), // 4
        Convert.ToByte("1011011", 2), // 5
        Convert.ToByte("1011111", 2), // 6
        Convert.ToByte("1110000", 2), // 7
        Convert.ToByte("1111111", 2), // 8
        Convert.ToByte("1111011", 2), // 9
    };

    static int n;
    static byte[] segments;
    static List<string> answers = new List<string>();
    static char[] currentAnswer;

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        segments = new byte[n];
        currentAnswer = new char[n];

        for (int i = 0; i < n; i++)
        {
            segments[i] = Convert.ToByte(Console.ReadLine(), 2);
        }

        Recursion(0);
        Console.WriteLine(answers.Count);
        foreach (var answer in answers)
        {
            Console.WriteLine(answer);
        }
    }

    private static void Recursion(int numberPosition)
    {
        if (numberPosition == n)
        {
            answers.Add(new string(currentAnswer));
            return;
        }
        else
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if ((digits[i] & segments[numberPosition]) == segments[numberPosition])
                {
                    currentAnswer[numberPosition] = (char)('0' + i);
                    Recursion(numberPosition + 1);
                }
            }
        }
    }
}