using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BigInteger> numbers = new List<BigInteger>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(BigInteger.Parse(Console.ReadLine()));
            }

            var oddNumber = numbers.GroupBy(x => x)
                                   .Where(g => g.Count() % 2 != 0)
                                   .Select(y => y.Key)
                                   .ToList();

            foreach (var item in oddNumber)
            {
                Console.WriteLine(item);
            }
        }
    }
}
