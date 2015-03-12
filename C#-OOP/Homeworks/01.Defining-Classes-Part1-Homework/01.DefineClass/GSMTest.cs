namespace GSMproject
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MobilePhoneTest
    {
        
        static void Main()
        {
            // Using the ToString overridden method
            Console.WriteLine("Using the overriden ToString to Print out added GSMs");
            GSM gsmOne = new GSM("Brokia", "Vesko Pichagata", 18.44m);
            GSM gsmTwo = new GSM("SamIang", "A local gypsy", 12m);
            GSM gsmThree = new GSM("BMW", "Oneq izrudi, deto mi iskaha hilqdi levove za remont", 13.37m);
            GSM gsmFour = new GSM("Some chinese iShone", "12 year old straving kids", 8.34m);

            var gsmArray = new[] {gsmOne, gsmTwo, gsmThree, gsmFour};
            foreach (var gsm in gsmArray)
            {
                Console.WriteLine(gsm);
            }

            // Displaying the iPhone data
            Console.WriteLine("\nIphone data below:");
            Console.WriteLine(GSM.Iphone4s);  
         
            // Print the call history
            Console.WriteLine("\nCALL HISTORY BELOW:");
            GSMCallHistoryTest.CallHistoryTest();           
        }
    }
}
