using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDamage
{
    class ShipDamage
    {
        static void Main(string[] args)
        {
            int sX1 = int.Parse(Console.ReadLine());
            int sY1 = int.Parse(Console.ReadLine());
            int sX2 = int.Parse(Console.ReadLine());
            int sY2 = int.Parse(Console.ReadLine());

            int H = int.Parse(Console.ReadLine());

            int cX1 = int.Parse(Console.ReadLine());
            int cY1 = int.Parse(Console.ReadLine());
            int cX2 = int.Parse(Console.ReadLine());
            int cY2 = int.Parse(Console.ReadLine());
            int cX3 = int.Parse(Console.ReadLine());
            int cY3 = int.Parse(Console.ReadLine());

            // Calculate where the shots land
            cY3 = (H * 2) - cY3;
            cY2 = (H * 2) - cY2;
            cY1 = (H * 2) - cY1;

            // Make sure sX2 and sY2 is always the bigger one
            if (sX1 > sX2)
            {
                int temp = sX1;
                sX1 = sX2;
                sX2 = temp;
            }

            if (sY1 > sY2)
            {
                int temp = sY1;
                sY1 = sY2;
                sY2 = temp;
            }

            // Check if we hit the ship            
            int damage = 0;

            // C1
            // Проверка дали Y на удара  С е между Y-ците на кораба
            // Проверка дали X на удара C е между Х-вете на кораба
            if (sX1 < cX1 && cX1 < sX2 && cY1 > sY1 && cY1 < sY2) 
            {
                damage += 100;
            }
            else if (cX1 == sX2 && cY1 > sY1 && cY1 < sY2 || // Проверка дали сме уцелили лявата страна
                    cX1 == sX1 && cY1 > sY1 && cY1 < sY2 || // Проверка дали сме уцелили дясната страна
                    cY1 == sY2 && sX1 < cX1 && cX1 < sX2 || // Проверка дали сме уцелили горната страна
                    cY1 == sY1 && sX1 < cX1 && cX1 < sX2)  // Проверка дали сме уцелили долната страна
            {
                damage += 50;
            }
            else if (cX1 == sX1 && cY1 == sY1 || // Проверка дали сме уцелили точката долу в дясно
                    cX1 == sX2 && cY1 == sY1 || // Проверка дали сме уцелили точката долу в ляво
                    cX1 == sX1 && cY1 == sY2 || // Проверка дали сме уцелили точката горе в дясно
                    cX1 == sX2 && cY1 == sY2) // Проверка дали сме уцелили точката горе в ляво
            {
                damage += 25;
            }

            // C2
            if (sX1 < cX2 && cX2 < sX2 && cY2 > sY1 && cY2 < sY2)
            {
                damage += 100;
            }
            else if (cX2 == sX2 && cY2 > sY1 && cY2 < sY2 ||
                    cX2 == sX1 && cY2 > sY1 && cY2 < sY2 || 
                    cY2 == sY2 && sX1 < cX2 && cX2 < sX2 || 
                    cY2 == sY1 && sX1 < cX2 && cX2 < sX2)  
            {
                damage += 50;
            }
            else if (cX2 == sX1 && cY2 == sY1 ||
                    cX2 == sX2 && cY2 == sY1 || 
                    cX2 == sX1 && cY2 == sY2 || 
                    cX2 == sX2 && cY2 == sY2) 
            {
                damage += 25;
            }

            // C3
            if (sX1 < cX3 && cX3 < sX2 && cY3 > sY1 && cY3 < sY2)
            {
                damage += 100;
            }
            else if (cX3 == sX2 && cY3 > sY1 && cY3 < sY2 ||
                    cX3 == sX1 && cY3 > sY1 && cY3 < sY2 ||
                    cY3 == sY2 && sX1 < cX3 && cX3 < sX2 ||
                    cY3 == sY1 && sX1 < cX3 && cX3 < sX2)
            {
                damage += 50;
            }
            else if (cX3 == sX1 && cY3 == sY1 ||
                    cX3 == sX2 && cY3 == sY1 ||
                    cX3 == sX1 && cY3 == sY2 ||
                    cX3 == sX2 && cY3 == sY2)
            {
                damage += 25;
            }

            Console.WriteLine("{0}%", damage);
        }
    }
}
