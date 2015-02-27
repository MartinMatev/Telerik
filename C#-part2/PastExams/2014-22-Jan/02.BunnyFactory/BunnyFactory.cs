using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class BunnyFactory
{
    static void Main()
    {
        
        var cages = ReadInput();

        for (int stepNumber = 1; true ; stepNumber++)
        {
            if (cages.Count < stepNumber)
            {
                break;
            }

            var cagesCount = (int)SumListValuesInRange(cages, 0, stepNumber - 1);
            if (cages.Count < stepNumber + cagesCount)
            {
                break;
            }

            var sum = SumListValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
            var product = ProductListValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
            string result = sum.ToString() + product.ToString();

            for (int i = cagesCount + stepNumber; i < cages.Count; i++)
            {
                result += cages[i];
            }

            cages.Clear();
            foreach (var symbol in result)
            {
                if (symbol != '0' && symbol != '1')
                {
                    cages.Add(symbol - '0');
                }
            }
        }

        Console.WriteLine(string.Join(" ", cages));
    }

    static BigInteger SumListValuesInRange(List<int> list, int startIndex, int endIndex)
    {
        BigInteger sum = 0;
        for (int i = startIndex; i <= endIndex; i++) 
        {
            sum += list[i];
        }

        return sum;
    }
    static BigInteger ProductListValuesInRange(List<int> list, int startIndex, int endingIndex)
    {
        BigInteger product = 1;
        for (int i = startIndex; i <= endingIndex; i++)
        {
            product *= list[i];
        }

        return product;
    }
    static List<int> ReadInput()
    {

        var cages = new List<int>();
        while (true)
        {
            var line = Console.ReadLine();
            if (line == "END")
            {
                break;
            }

            var cage = int.Parse(line);
            cages.Add(cage);
        }
        return cages;  
    }
}