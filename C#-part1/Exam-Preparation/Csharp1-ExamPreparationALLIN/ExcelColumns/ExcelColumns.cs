using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelColumns
{
    class ExcelColumns
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());;
            long currentPoints = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                string letter = Console.ReadLine().ToUpper();
                int ch = Convert.ToChar(letter) - '@';
                currentPoints += ch * (long)Math.Pow(26, i);
            }

            Console.WriteLine(currentPoints);
        }
    }
}
