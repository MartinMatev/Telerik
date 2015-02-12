using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            uint tomatoSeeds = uint.Parse(Console.ReadLine());
            uint tomatoArea = uint.Parse(Console.ReadLine());
            uint cucumberSeeds = uint.Parse(Console.ReadLine());
            uint cucumberArea = uint.Parse(Console.ReadLine());
            uint potatoSeeds = uint.Parse(Console.ReadLine());
            uint potatoArea = uint.Parse(Console.ReadLine());
            uint carrotSeeds = uint.Parse(Console.ReadLine());
            uint carrotArea = uint.Parse(Console.ReadLine());
            uint cabbageSeeds = uint.Parse(Console.ReadLine());
            uint cabbageArea = uint.Parse(Console.ReadLine());
            uint beansSeeds = uint.Parse(Console.ReadLine());

            uint maxArea = 250;
            uint totalArea = 0;
            decimal totalSeedCost = 0.0m;

            totalSeedCost += 0.5m * (decimal)tomatoSeeds;
            totalSeedCost += 0.4m * (decimal)cucumberSeeds;
            totalSeedCost += 0.25m * (decimal)potatoSeeds;
            totalSeedCost += 0.6m * (decimal)carrotSeeds;
            totalSeedCost += 0.3m * (decimal)cabbageSeeds;
            totalSeedCost += 0.4m * (decimal)beansSeeds;

            totalArea += tomatoArea;
            totalArea += cucumberArea;
            totalArea += potatoArea;
            totalArea += carrotArea;
            totalArea += cabbageArea;

            Console.WriteLine("Total costs: {0:F2}", totalSeedCost);

            if (totalArea > maxArea)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (totalArea == maxArea)
            {
                Console.WriteLine("No area for beans");
            }
            else if (totalArea < maxArea)
            {
                Console.WriteLine("Beans area: {0}", maxArea - totalArea);
            }
        }
    }
}
