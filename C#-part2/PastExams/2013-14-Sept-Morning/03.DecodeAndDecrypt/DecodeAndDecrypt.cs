using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DecodeAndDecrypt
{
    /* Logic Explanation:
     * 
     * ABBAA6BA7                => Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher
     * 7                        => lengthOfCypher
     * ABBAA6BA                 => Encode(Encrypt(message, cypher) + cypher) 
     * ABBAABBBBBBA             => Encrypt(message, cypher) + cypher
     * BBBBBBA                  => cypher
     * ABBAA                    => Encrypt(message, cypher)
     * Encrypt("ABBAABBBBBBA", cypher)  => message
     */
    static void Main()
    {
        string input = Console.ReadLine();

        // Step.1 Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher
        List<int> digits = new List<int>();
        for (int i = input.Length - 1; i > 0; i--)
        {
            if (char.IsDigit(input[i]))
            {
                digits.Add(input[i] - '0');
            }
            else
            {
                break;
            }
        }

        // Reverse the digits, since they are in the LIST backwards, so we need em in the proper order
        digits.Reverse();

        // Step.3 lengthOfCypher
        // Using NUMERAL systems, we combine the digits into a DECIMAL number
        int lengthOfCypher = 0;
        foreach (var digit in digits)
        {
            lengthOfCypher *= 10;
            lengthOfCypher += digit;
        }

        // Step.3 Encode(Encrypt(message, cypher) + cypher)
        // We take ONLY the message, by Substringing from the beggining, until input.Length - digits.Count
        string encodedMessage = input.Substring(0, input.Length - digits.Count);

        // Step.4 Encrypt(message, cypher) + cypher
        // Will result in ABBAABBBBBBA
        string decodedMessage = Decode(encodedMessage);

        // Step.5 Encrypt(message, cypher)
        // Will result in ABBAA
        string encryptedMessage = decodedMessage.Substring(0, decodedMessage.Length - lengthOfCypher);

        // Step.6 cypher
        // Will result in BBBBBBA
        var cypher = decodedMessage.Substring(decodedMessage.Length - lengthOfCypher, lengthOfCypher);

        // Step.7 Encrypt("ABBAABBBBBBA", cypher)  => message
        string message = Encrypt(encryptedMessage, cypher);
        Console.WriteLine(message);
    }

    private static string Decode(string encodedMessage)
    {
        // ABBAA6BA  =>  ABBAABBBBBBA
        StringBuilder result = new StringBuilder();
        int count = 0;

        foreach (var ch in encodedMessage)
        {
            if (char.IsDigit(ch))
            {
                count *= 10;
                count += (ch - '0');
            }
            else
            {
                if (count == 0)
                {
                    result.Append(ch);
                }
                else
                {
                    result.Append(ch, count);   // adds the ch symbol, count number of times
                    count = 0;
                }
            }
        }

        return result.ToString();
    }

    private static string Encrypt(string message, string cypher)
    {
        int steps = (int)Math.Max(message.Length, cypher.Length);
        StringBuilder result = new StringBuilder(message);
        
        for (int step = 0; step < steps; step++)
        {
            int messageIndex = step % message.Length;
            int cypherIndex = step % cypher.Length;
            result[messageIndex] = (char)(((result[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
        }
        return result.ToString();
    }
}
