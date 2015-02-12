using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.
class IndexOfLetters
{
    static void Main()
    {
        // Generate a sequence FROM the letter 'A', UNTIL 26 are generated ('Z' - 'A' + 1 == 26(the whole alphabet))
        char[] aToZletters = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();
        Console.Write("Type in a single word: ");
        string input = Console.ReadLine().ToUpper();

        foreach (char letter in input)
        {
            int index = Array.IndexOf(aToZletters, letter);
            // Check if such index exists, otherwise the letter(if at all) isn't present in the array
            if (index >= 0)
            {
                Console.WriteLine("The index of letter {0} is: {1}", letter, index);
            }
            else
            {
                Console.WriteLine("No index for {0}, most probably not a letter at all", letter);
            }
        }
    }
}
