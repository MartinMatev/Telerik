using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MoonGravitation
{
    class MoonGravity
    {
        // The gravitational field of the Moon is approximately 17% of that on the Earth.
        // Write a program that calculates the weight of a man on the moon by a given weight on the Earth
        static void Main(string[] args)
        {
            double earthWeight;
            if (double.TryParse(Console.ReadLine(), out earthWeight))
            {
                double moonWeight = earthWeight * 0.17;
                Console.WriteLine("Your moon weigth would be: {0}", moonWeight);
            }
        }
    }
}
