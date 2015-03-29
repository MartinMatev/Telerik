using System;

namespace RangeExceptions
{
    class Tests
    {
        static readonly int startInt = 1;
        static readonly int endInt = 100;
        static readonly DateTime startDate = new DateTime(1980, 1, 1);
        static readonly DateTime endDate = new DateTime(2013, 12, 31);
        static void Main()
        {
            // Change the wrong values, to ones that pass the try{} section to make sure if works.
            int wrongNumber = 1337;
            DateTime wrongDate = DateTime.Now;

            try
            {
                // Comment out this if, in order to throw the DateTime exception
                if (wrongNumber < startInt || wrongNumber > endInt)
                {
                    throw new InvalidRangeException<int>("ACCESS DENIED. Number", 1, 100);
                }

                if (wrongDate < startDate || wrongDate > endDate)
                {
                    throw new InvalidRangeException<DateTime>("MISMATCH. Date", startDate, endDate);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
