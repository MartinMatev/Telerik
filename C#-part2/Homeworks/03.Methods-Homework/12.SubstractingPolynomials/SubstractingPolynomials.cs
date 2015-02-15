using System;
using System.Linq;

// Extend the previous program to support also subtraction and multiplication of polynomials.
class SubstractingPolynomials
{
    static void Main()
    {
        // will implement only substracting and multiplication since SUMMING is already done in the previous assignment!
        char operation = GetOperation();
        decimal[] firstPolynomial = GetPolynomial("first");
        decimal[] secondPolynomial = GetPolynomial("second");

        PrintResult(firstPolynomial);
        PrintResult(secondPolynomial);

        if (operation == '-')
        {
            int maxLength = Math.Max(firstPolynomial.Length, secondPolynomial.Length);
            int minLength = Math.Min(firstPolynomial.Length, secondPolynomial.Length);
            SubstractingPolynomial(firstPolynomial, secondPolynomial, minLength, maxLength);
        }
        else if (operation == '*')
        {
            int maxLength = firstPolynomial.Length * secondPolynomial.Length;
            MultiplyingPolynomial(firstPolynomial, secondPolynomial, maxLength);
        }

    }

    private static void MultiplyingPolynomial(decimal[] firstPolynomial, decimal[] secondPolynomial, int maxLength)
    {
        decimal[] result = new decimal[maxLength];

        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                int position = i + j;
                result[position] += (firstPolynomial[i] * secondPolynomial[j]);
            }
        }
        PrintResult(result);
    }

    private static void SubstractingPolynomial(decimal[] firstPolynomial, decimal[] secondPolynomial, int minLength, int maxLength)
    {
        decimal[] result = new decimal[maxLength];

        for (int i = 0; i < minLength; i++)
        {
            result[i] = firstPolynomial[i] - secondPolynomial[i];
        }

        for (int i = minLength; i < maxLength; i++)
        {
            if (firstPolynomial.Length == maxLength)
            {
                result[i] = firstPolynomial[i];
            }
            else
            {
                result[i] = secondPolynomial[i];
            }
        }
        PrintResult(result);
    }

    private static void PrintResult(decimal[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0 && i != 0)
            {
                // Check if it is positive
                if (polynomial[i] >= 0)
                {
                    Console.Write("{1}x^{0} + ", i, polynomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polynomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polynomial[i]);
            }
        }
        Console.WriteLine();
    }

    private static decimal[] GetPolynomial(string p)
    {
        Console.WriteLine("Type in {0} polynomial, separated by space:", p);
        Console.Write(">>");
        return Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(x => decimal.Parse(x))
                                 .ToArray();
    }

    private static char GetOperation()
    {
        Console.Write("Type in - for substraction on * for multiplication: ");
        return char.Parse(Console.ReadLine());
    }
}
