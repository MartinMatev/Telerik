using System;

namespace _05.TimerApp
{
    class TimerTest
    {
        static void Main()
        {
            /*Problem 7. Timer
             * Using delegates write a class Timer that can execute certain method at each t seconds.
             */
            Timer myTimer = new Timer(1, 10, delegate() { Console.WriteLine("A new event has occured, oh joy !"); });
            myTimer.TickTack();
        }
    }
}
