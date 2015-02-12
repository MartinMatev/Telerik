using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main(string[] args)
        {
            byte rounds = byte.Parse(Console.ReadLine());
            long mitkoCounter = 0;
            long vladkoCounter = 0;

            for (int i = 0; i < rounds; i++)
            {
                string drunkenNumber = Console.ReadLine();
                StringBuilder positiveOnlyString = new StringBuilder();

                for (int numToCheck = 0; numToCheck < drunkenNumber.Length; numToCheck++)
                {
                    if (drunkenNumber[numToCheck] >= '0' && drunkenNumber[numToCheck] <= '9')
                    {
                        positiveOnlyString.Append(drunkenNumber[numToCheck]);
                    }
                }

                drunkenNumber = positiveOnlyString.ToString().TrimStart('0');

                if (drunkenNumber.Length % 2 == 0)
                {
                    for (int j = 0; j < drunkenNumber.Length / 2; j++)
                    {
                        mitkoCounter = (drunkenNumber[j] - '0') + mitkoCounter;
                    }
                    for (int j = drunkenNumber.Length / 2; j < drunkenNumber.Length; j++)
                    {
                        vladkoCounter = (drunkenNumber[j] - '0') + vladkoCounter;
                    }
                }
                else
                {
                    for (int j = 0; j < drunkenNumber.Length / 2 + 1; j++)
                    {
                        mitkoCounter = (drunkenNumber[j] - '0') + mitkoCounter;
                    }
                    for (int j = drunkenNumber.Length / 2; j < drunkenNumber.Length; j++)
                    {
                        vladkoCounter = (drunkenNumber[j] - '0') + vladkoCounter;
                    }
                }
                //bool isOdd = false;
                //for (int j = 0; j < drunkenNumber.Length; j++)
                //{
                //    if (drunkenNumber.Length % 2 != 0)
                //    {
                //        isOdd = true;
                //    }
                //    if (j < drunkenNumber.Length / 2)
                //    {
                //        mitkoCounter += (ulong)char.GetNumericValue((drunkenNumber[j]));
                //        if (isOdd && j == (drunkenNumber.Length / 2) - 1)
                //        {
                //            j++;
                //            mitkoCounter += (ulong)char.GetNumericValue((drunkenNumber[j]));
                //            j--;
                //        }
                //    }
                //    else if (j >= drunkenNumber.Length / 2)
                //    {
                //        vladkoCounter += (ulong)char.GetNumericValue((drunkenNumber[j]));
                //    }
                //}
            }

            if (mitkoCounter == vladkoCounter)
            {
                Console.WriteLine("No {0}", mitkoCounter + vladkoCounter);
            }
            else if (mitkoCounter > vladkoCounter)
            {
                Console.WriteLine("M {0}", mitkoCounter - vladkoCounter);
            }
            else if (vladkoCounter > mitkoCounter)
            {
                Console.WriteLine("V {0}", vladkoCounter - mitkoCounter);
            }
        }
    }
}
