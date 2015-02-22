using System;
using System.Text;

/*
 * Write a program that encodes and decodes a string using given encryption key (cipher).
 * The key consists of a sequence of characters.
 * The encoding/decoding is done by performing XOR (exclusive or) operation 
 * over the first letter of the string with the first of the key, 
 * the second – with the second, etc. 
 * When the last key character is reached, the next is the first.
 */
class EncodeDecode
{
    static void Main()
    {
        string cyper = GetInput("cypher");
        string text = GetInput("text");
        Console.WriteLine("Encrypted text: {0}", Encrypt(cyper, text));

    }

    private static string Encrypt(string cyper, string text)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            result.Append((char)(cyper[i % cyper.Length] ^ text[i]));           
        }
        return result.ToString();
    }

    private static string GetInput(string p)
    {
        Console.WriteLine("Enter the {0} below:", p);
        Console.Write(">> ");
        return Console.ReadLine();
    }
}
