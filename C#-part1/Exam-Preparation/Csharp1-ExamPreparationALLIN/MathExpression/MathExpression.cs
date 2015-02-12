using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string inputN = Console.ReadLine();
            string inputM = Console.ReadLine();
            string inputP = Console.ReadLine();
            double n = double.Parse(inputN);
            double m = double.Parse(inputM);
            double p = double.Parse(inputP);

            const double numberLeet = 1337;
            const double numberDenom = 128.523123123;
            double nominator = n * n + 1 / (m * p) + numberLeet;
            double denominator = n - numberDenom * p;

            double result = nominator / denominator + Math.Sin((int)m % 180);
            Console.WriteLine("{0:F6}", result);
        }
    }
}
