using System;

namespace _06.Events
{
    class TimerEventTest
    {
        /*
         * Problem 8.* Events
         * Read in MSDN about the keyword event in C# and how to publish events.
         * Re-implement the above using .NET events and following the best practices.
         */
        static void Main()
        {
            Timer myTimer = new Timer(1, 10);
            myTimer.TimeElapsed += PrintChange;
            myTimer.TickTack();
        }

        public static void PrintChange(object sender, TimeEventArgs e)
        {
            Console.WriteLine("An event has occured! Event number {0}", e.TicksCount);
        }
    }
}
