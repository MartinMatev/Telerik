using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccounts
{
    public class Tests
    {
        static void Main()
        {
            Bank myBank = new Bank();
            myBank.AddAccount(new DepositAccount(new Individuals("Bai Ivan", "Shisharka str", "893873", 7804659087), 5000m, 30m));
            myBank.AddAccount(new MortgageAccount(new Companies("Falit OOD", "Prtst str", "+3592889765", 8653527848726), 100m, 40m));
            myBank.AddAccount(new LoanAccount(new Individuals("Gib Monei", "Middle of nowhere", "+122734471", 8809136173), 9999m, 100m));
            myBank.AddAccount(new MortgageAccount(new Individuals("Mitko", "U tqh si", "+359889882345", 8903130490), 1020.345m, 4.5m));

            Console.WriteLine("Displaying different account's data:");
            Console.WriteLine(myBank);

            Console.WriteLine("\nDisplaying the result from the interest calculations:");

            int month = 7;
            foreach (var account in myBank)
            {
                Console.WriteLine("Name: {1} - Period(months): {2} - Interest calc result: {0:c}", account.InterestCalculations(month), account.Customer.Name, month);
            }

            var queryResult = myBank.Select(x => new { Name = x.Customer.Name, Period = month, Result = x.InterestCalculations(month)}).OrderBy(y => y.Result).ToList();

            foreach (var result in queryResult)
            {
                Console.WriteLine(queryResult);            
            }
        }
    }
}
