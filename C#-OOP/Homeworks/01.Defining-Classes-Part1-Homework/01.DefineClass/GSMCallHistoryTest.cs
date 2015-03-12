namespace GSMproject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMCallHistoryTest
    {
        
        public static void CallHistoryTest()
        {
            GSM myGsm = new GSM("Nokia from 12 years ago", "ot selo", 2.50m, "Jambaza", new Display(5, 0226), new Battery("Arbait"));

            myGsm.MakingCalls(new Call("00359213345", 2313312));
            myGsm.MakingCalls(new Call("00359214532", 3213313));
            myGsm.MakingCalls(new Call("00359432345", 123));
            myGsm.MakingCalls(new Call("00359211011", 43543));
            myGsm.MakingCalls(new Call("00359127898", 1234));

            // Print out the call history of the object myGsm
            myGsm.PrintCallHistory();

            // print out the total expenses
            Console.WriteLine("\nTotal expenses: ");
            decimal result = myGsm.TotalPrice();
            Console.WriteLine("Total: {0:c}", result);

            // Find out which call has the longest duration
            var allCallDurations = myGsm.CallHistory.Select(x => x.CallDuration).ToList();
            ulong longestCall = 0;
            int longestCallIndex = 0;
            foreach (var call in allCallDurations)
            {
                if (call > longestCall)
                {
                    longestCall = call;
                    longestCallIndex = allCallDurations.IndexOf(call);
                }
            }

            myGsm.DeletingCalls(longestCallIndex);

            // Printing the expenses without the longest call
            Console.WriteLine("\nTotal expenses WITHOUT longest call:");
            result = myGsm.TotalPrice();
            Console.WriteLine("Total: {0:c}", result);

            // Clearing the history and printing empty results
            Console.WriteLine("\nHistory clear!");
            myGsm.DeletingHistory();
            myGsm.PrintCallHistory();
            result = myGsm.TotalPrice();
            Console.WriteLine("Total: {0:c}", result);
        }
    }
}
