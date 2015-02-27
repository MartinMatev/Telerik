using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OneTaskIsNotEnough
{
    static void Main()
    {
        // First task
        Lamps();

        // Second task

        Robot();
        Robot();
    }

    private static void Lamps()
    {
        int countOff = int.Parse(Console.ReadLine());

        var turnOnNow = new bool[countOff + 1];
        var lampsStillOff = new int[countOff + 1];

        int lastLamp = 0;

        for (int i = 1; i <= countOff; i++)
        {
            lampsStillOff[i] = i;
        }

        int jump = 1;
        while (countOff > 0)
        {
            jump++;

            Array.Clear(turnOnNow, 1, countOff);

            for (int i = 1; i <= countOff; i += jump)
            {
                turnOnNow[i] = true;
            }
            int newCountOff = 0;
            for (int i = 1; i <= countOff; i++)
            {
                if (turnOnNow[i] == false)
                {
                    newCountOff++;
                    lampsStillOff[newCountOff] = lampsStillOff[i];
                    lastLamp = lampsStillOff[i];
                }
            }
            countOff = newCountOff;
        }

        Console.WriteLine(lastLamp);
    }

    private static void Robot()
    {
        string commands = Console.ReadLine();

        int[] dx = { 1, 0, -1, 0 }; // 1} на дясно| 0} на горе |-1} на ляво | 0} на долу
        int[] dy = { 0, 1, 0, -1 }; // 0}         | 1}         | 0}         |-1}

        int x = 0;
        int y = 0;
        int orientation = 0;

        for (int i = 0; i < 4; i++)
        {
            foreach (var command in commands)
            {
                if (command == 'S')
                {
                    x = x + dx[orientation];
                    y = y + dy[orientation];
                }
                else if (command == 'L')
                {
                    orientation -= 1;
                    orientation += 4;
                    orientation %= 4;
                }
                else if (command == 'R')
                {
                    orientation += 1;
                    orientation %= 4;
                }
            }
        }

        if (x == 0 && y == 0)
        {
            Console.WriteLine("bounded");
        }
        else
        {
            Console.WriteLine("unbounded");
        }
    }
}
