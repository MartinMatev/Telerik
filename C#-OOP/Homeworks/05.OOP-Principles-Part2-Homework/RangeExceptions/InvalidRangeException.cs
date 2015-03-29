using System;

namespace RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
    {
        public T Start { get; private set; }

        public T End { get; private set; }

        public InvalidRangeException(string message, Exception innerException, T start, T end) : base(string.Format("{0} must be between {1} and {2}", message, start, end), innerException)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end) : this(message, null, start, end)
        {

        }
    }
}
