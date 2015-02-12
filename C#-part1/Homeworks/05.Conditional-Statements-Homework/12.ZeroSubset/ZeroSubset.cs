using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// Assume that repeating the same subset several times is not a problem.
namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] numbersArray = new int[5];

            // A "for" loop, used for assigning 5 values 
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Type in number {0} / 5: ", i + 1);
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            // Loop through 1 to 31 (the binary representation of these numbers cover ALL possible combinations for 5 numbers - 2^5 - 1)
            for (int i = 1; i <= 31; i++)
            {
                // Create a list to which dynamiaclly to add members of the subsets
                List<int> currentCombinationNumbers = new List<int>();
                int currentSum = 0;

                for (int j = 0; j < 5; j++)
                {
                    // We take every signle bit through all iterations of this "for" cycle (5 cycles total)
                    // bitwise & compare it to a mask and write it down in the variable "bit"
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;

                    // If the bit turned out to be 1, we add the value of the number in the numberArray
                    // corresponding to the same position as the position of that bit to the currentSum
                    if (bit == 1)
                    {
                        // Add subset members to the list which to display if their sum equals 0
                        currentCombinationNumbers.Add(Convert.ToInt32(numbersArray[j]));
                        currentSum += numbersArray[j];                        
                    }
                }
                if (currentSum == 0)
                {
                    count++;
                    int listSize = currentCombinationNumbers.Count;

                    for (int k = 0; k < listSize; k++)
                    {
                        if (k < listSize - 1)
                        {
                            Console.Write("{0} + ", currentCombinationNumbers[k]);
                        }
                        else if (k == listSize - 1)
                        {
                            Console.WriteLine("{0} = 0 ", currentCombinationNumbers[k]);
                        }
                    }
                }
            }
            Console.WriteLine("The total number of subset that equal zero : {0}", count);
        }
    }
}
/*
Метода прави всички възможни комбинации, за това при пет 0-ли вади всичките 31, като комбинира всяка една нула
с другите и отделно счита всяка една самостоятелна нула за отговор на задачата
При примера с единиците прави същото, просто там възможните комбинации са по-малко, за това 1 + -1 = 0
го прави няколко пъти, просто комбинира различните единици.
*/