using System;
using System.Linq;
using System.Text;

// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
class Palindromes
{
    static void Main()
    {
        string input = "Dorothy, ABBA and lamal went on a hike in the forest. Little did they know, that exe, the slayer of bunnies was out on a hunting trip that noon.";

        Console.WriteLine("{0}", GetPalindromes(input));
    }

    private static string GetPalindromes(string input)
    {
        StringBuilder palindromes = new StringBuilder();
        int minimum = 3;    // The minimum requirement for a palindrome to be such in the first  place

        for (int i = 0; i < input.Length - minimum; i++)
        {
            for (int j = i + minimum; j < input.Length - minimum; j++)
            {
                string normalVersion = input.Substring(i, j - i);
                string reversedVersion = new string(normalVersion.Reverse().ToArray());

                // If reversing the substring yields the same result, and that doesn't include BLANK spaces, add it to the result
                if (normalVersion == reversedVersion && input[i] != ' ')
                {
                    palindromes.AppendLine(normalVersion);
                }
            }
        }

        return palindromes.ToString();
    }
}
