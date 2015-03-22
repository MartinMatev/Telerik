using System;

namespace _06.Events
{
    public class TimeEventArgs : EventArgs
    {
        private int ticksCount;

        public TimeEventArgs(int ticks)
        {
            this.TicksCount = ticks;
        }

        public int TicksCount
        {
            get { return ticksCount; }
            set { ticksCount = value; }
        }
    }
}
