using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anacci
{
    class Anacci
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine().ToUpper());
            char secondChar = char.Parse(Console.ReadLine().ToUpper());
            int n = int.Parse(Console.ReadLine());
            char[] alphabetArray = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int firstCharNum = 0;
            int secondCharNum = 0;
            for (int i = 0; i < alphabetArray.Length; i++)
            {
                if (alphabetArray[i] == firstChar)
                {
                    firstCharNum = i + 1;
                }
                if (alphabetArray[i] == secondChar)
                {
                    secondCharNum = i + 1;
                }
            }

            int sum = FindSum(firstCharNum, secondCharNum);

            int whiteSpaceCount = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    if (row >= 2)
                    {
                        whiteSpaceCount++;
                    }

                    if (row == 0)
                    {
                        Console.Write(firstChar);
                        break;
                    }
                    else if (row == 1)
                    {
                        Console.Write(secondChar);
                        Console.Write(alphabetArray[sum - 1]);
                        break;
                    }
                    else
                    {
                        firstCharNum = secondCharNum;
                        secondCharNum = sum;
                        sum = FindSum(firstCharNum, secondCharNum);

                        Console.Write(alphabetArray[sum - 1]);
                        Console.Write(new string(' ', whiteSpaceCount));

                        firstCharNum = secondCharNum;
                        secondCharNum = sum;
                        sum = FindSum(firstCharNum, secondCharNum);

                        Console.Write(alphabetArray[sum - 1]);
                    }
                }
                Console.WriteLine();
            }
        }
        static int FindSum(int first, int second)
        {
            int sum = first + second;
            if (sum > 26)
            {
                sum = sum % 26;
            }
            return sum;
        }
    }
}
