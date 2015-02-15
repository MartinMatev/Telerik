using System;
using System.Linq;

/*
 * Write a method that adds two polynomials.
   Represent them as arrays of their coefficients.
   Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
 */
class AddingPolynomials
{
    static void Main()
    {
        WarningMessage();
        decimal[] firstPolynomial = GetPolynomial("first");
        decimal[] secondPolynomial = GetPolynomial("second");
        PrintPolynomials(firstPolynomial, "First polynomial");
        PrintPolynomials(secondPolynomial, "Second polynomial");

        int maxLength = Math.Max(firstPolynomial.Length, secondPolynomial.Length);
        int minLength = Math.Min(firstPolynomial.Length, secondPolynomial.Length);
        CalculateSum(firstPolynomial, secondPolynomial, minLength, maxLength);

    }

    private static void WarningMessage()
    {
        Console.WriteLine("LAST digit is x^0, second to last is x^1 and SO ON");
        Console.WriteLine("EXAMPLE: 3 - 1 + 6 EQUALS 6x^2 - x + 3");
        Console.WriteLine("do NOT type in x or power, just the number, keeping in mind the message above!");
        Console.WriteLine();
    }

    private static void CalculateSum(decimal[] firstPolynomial, decimal[] secondPolynomial, int minLength, int maxLength)
    {
        decimal[] result = new decimal[maxLength];

        // Sum the values of the two arrays (take into account that 1 of them may be smaller
        // , so sum only the values that exist in BOTH arrays)
        for (int i = 0; i < minLength; i++)
        {
            result[i] = firstPolynomial[i] + secondPolynomial[i];
        }

        // Add the remaining values of the bigger array
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
        PrintPolynomials(result, "Result polynomial");
    }

    private static void PrintPolynomials(decimal[] polynomial, string from)
    {
        Console.WriteLine("{0}: ", from);
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            // Loop backwards and check if the current element is NOT the last one && it's not 0 (because 0x^n == 0)
            if (polynomial[i] != 0 && i != 0)
            {
                if (polynomial[i - 1] >= 0)
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
        return Console.ReadLine().Split(new char[]{' ', ',', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(x => decimal.Parse(x))
                                 .ToArray();
    }
}