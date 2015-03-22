using System;
using System.Threading;

namespace _06.Events
{
    
    public delegate void TimeEventHandler(object sender, TimeEventArgs e);
    class Timer
    {
        // fields
        private int interval;
        private int ticksCount;

        // constructor
        public Timer(int interval, int ticksCount)
        {
            this.Interval = interval;
            this.TicksCount = ticksCount;
        }

        // properties
        public int Interval
        {
            get
            {
                return this.interval;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Seconds cannot be below 0!");
                }
                this.interval = value * 1000;
            }
        }

        public int TicksCount
        {
            get
            {
                return this.ticksCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ticks count cannot be below 0!");
                }
                this.ticksCount = value;
            }
        }

        public event TimeEventHandler TimeElapsed;

        protected internal void OnTimeElapsed(int ticksCount)
        {
            if (TimeElapsed != null)
            {
                TimeElapsed(this, new TimeEventArgs(ticksCount));
            }
        }

        public void TickTack()
        {
            int limitCounter = ticksCount;
            ticksCount = 0;
            while (ticksCount < limitCounter)
            {
                Thread.Sleep((int)interval);
                ticksCount++;
                OnTimeElapsed(ticksCount);
            }
        }
    }
}
