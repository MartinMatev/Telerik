using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterAttack
{
    class FighterAttack
    {
        static void Main(string[] args)
        {
            int pX1 = int.Parse(Console.ReadLine());
            int pY1 = int.Parse(Console.ReadLine());
            int pX2 = int.Parse(Console.ReadLine());
            int pY2 = int.Parse(Console.ReadLine());

            if (pX1 > pX2)
            {
                int temp = pX1;
                pX1 = pX2;
                pX2 = temp;
            }
            if (pY1 > pY2)
            {
                int temp = pY1;
                pY1 = pY2;
                pY2 = temp;
            }

            int fX = int.Parse(Console.ReadLine());
            int fY = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());

            int damage = 0;
            // Изчисляваме предварително къде ще падне бомбата като я събираме с дистанцията
            fX += distance;

            // Ако влезе тука, значи бомбата е паднала вътре, между двете Х точки
            if (pX1 <= fX && fX <= pX2)
            {
                // Ако влезе тука, значи бомбата е между двете Y точки
                if (pY1 <= fY && fY <= pY2)
                {
                    damage += 100;
                }

                // Проверка за 2те точки отгоре и отдолу за по 50 демидж (те са на същите Х кординати)
                if (pY1 <= fY - 1 && fY - 1 <= pY2) // точката отдолу
                {
                    damage += 50;
                }
                if (pY1 <= fY + 1 && fY + 1 <= pY2) // точката отгоре
                {
                    damage += 50;
                }
            }

            if (pX1 <= fX + 1 && fX + 1 <= pX2)
            {
                if (pY1 <= fY && fY <= pY2)
                {
                    damage += 75;
                }
            }

            Console.WriteLine("{0}%", damage);
        }
    }
}
