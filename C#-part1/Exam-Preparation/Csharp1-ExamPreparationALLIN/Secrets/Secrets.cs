using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secrets
{
    class Secrets
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            number = BigInteger.Abs(number);
            string input = number.ToString();
            BigInteger specialSum = 0;

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            input =  new string(charArray);

            for (int i = 1; i <= input.Length; i++)
            {
                int convertedDigit = input[i - 1] - '0';
                if (i % 2 == 0)
                {
                    specialSum += (convertedDigit * convertedDigit) * i;
                }
                else
                {
                    specialSum += (convertedDigit) * (i * i);
                }
            }

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool noSecretSequence = false;
            string sequence = "";

            BigInteger sequenceLenght = specialSum % 10;
            if (sequenceLenght == 0)
            {
                noSecretSequence = true;
            }

            int r = (int)(specialSum % 26);
            for (int i = 0; i < sequenceLenght; i++)
            {
                sequence += alphabet[r];
                if (r == 25)
                {
                    r = 0;
                }
                else
                {
                    r++;
                }
            }

            Console.WriteLine(specialSum);
            if (noSecretSequence)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
            else
            {
                Console.WriteLine(sequence);
            }
        }
    }
}
