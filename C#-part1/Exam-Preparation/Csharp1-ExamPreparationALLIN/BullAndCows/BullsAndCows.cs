﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullAndCows
{
    class BullsAndCows
    {
        static void Main(string[] args)
        {
            string secretNum = Console.ReadLine();
            int targetBulls = int.Parse(Console.ReadLine());
            int targetCows = int.Parse(Console.ReadLine());
            const char usedSecretNum = '*';
            const char usedGuessNum = '@';

            List<int> results = new List<int>();

            for (int num = 1000; num < 9999; num++)
            {
                int countFoundBulls = 0;
                int countFoundCows = 0;
                char[] digitsGuess = num.ToString().ToCharArray();

                char[] secretNumDigits = secretNum.ToCharArray();

                if (digitsGuess[0] >= '1' && digitsGuess[1] >= '1' && digitsGuess[2] >= '1' && digitsGuess[3] >= '1')
                {
                    for (int i = 0; i < digitsGuess.Length; i++)
                    {
                        if (digitsGuess[i] == secretNumDigits[i])
                        {
                            countFoundBulls++;
                            digitsGuess[i] = usedGuessNum;
                            secretNumDigits[i] = usedSecretNum;
                        }
                    }


                    for (int secretIndex = 0; secretIndex < digitsGuess.Length; secretIndex++)
                    {
                        for (int guessIndex = 0; guessIndex < digitsGuess.Length; guessIndex++)
                        {
                            if (secretNumDigits[secretIndex] == digitsGuess[guessIndex])
                            {
                                countFoundCows++;
                                digitsGuess[guessIndex] = usedGuessNum;
                                secretNumDigits[secretIndex] = usedSecretNum;
                            }
                        }
                    }

                    if (countFoundCows == targetCows && countFoundBulls == targetBulls)
                    {
                        results.Add(num);
                    }
                }
            }

            if (results.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = 0; i < results.Count; i++)
                {
                    Console.Write(results[i] + " ");
                }
            }
        }
    }
}