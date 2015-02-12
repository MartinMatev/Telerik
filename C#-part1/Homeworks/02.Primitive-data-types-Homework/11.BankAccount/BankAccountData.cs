using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
// bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
namespace _11.BankAccount
{
    class BankAccountData
    {
        // Create a struct that will contain the data of the account.
        struct AccountHolder
        {
            public string firstName;
            public string middleName;
            public string lastName;
            public decimal moneyAmount;
            public string bankName;
            public string iban;
            public string firstCard;
            public string secondCard;
            public string thirdCard;
        }
        static void Main(string[] args)
        {
            // Create an infinite loop
            while (true)
            {
                // Catches format errors and displays the appropriate message
                try
                {
                    // Create a new instace of the struct AccountHolder
                    AccountHolder newAccount = new AccountHolder();

                    Console.WriteLine("\nPlease type in the new account holder's data below!\n");
                    Console.Write("Enter the account holder's first name: ");
                    newAccount.firstName = Console.ReadLine();

                    Console.Write("Enter the account holder's middle name: ");
                    newAccount.middleName = Console.ReadLine();

                    Console.Write("Enter the account holder's last name: ");
                    newAccount.lastName = Console.ReadLine();

                    Console.Write("Enter the account holder's bank name: ");
                    newAccount.bankName = Console.ReadLine();

                    Console.Write("Enter the account holder's iban: ");
                    newAccount.iban = Console.ReadLine();

                    Console.Write("Enter the account holder's money mount: ");
                    newAccount.moneyAmount = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter the account holder's first card number: ");
                    newAccount.firstCard = Console.ReadLine();

                    Console.Write("Enter the account holder's second card number: ");
                    newAccount.secondCard = Console.ReadLine();

                    Console.Write("Enter the account holder's third card number: ");
                    newAccount.thirdCard = Console.ReadLine();

                    // Display the data
                    Console.WriteLine("\nThe new account holder's data you just entered:" +
                        "\nFirst name: {0}\nMiddle name: {1}\nLast name: {2}\nBank name: {3}\niban: {4}\nmoney amount: {5}" +
                        "\nFirst card: {6}\nSecond card: {7}\nThird card: {8}",
                        newAccount.firstName, newAccount.middleName, newAccount.lastName,
                        newAccount.bankName, newAccount.iban, newAccount.moneyAmount,
                        newAccount.firstCard, newAccount.secondCard, newAccount.thirdCard);

                    // Check if the user wants to continue adding accounts. Break the while cycle by typing in the word "exit"
                    Console.WriteLine("\nPress any key to continue, or type in \"exit\", without quotations to exit the application");
                    if (Console.ReadLine() == "exit")
                    {
                        Environment.Exit(0);
                    }
                }
                catch
                {
                    Console.WriteLine("Please input the data in the right format!");
                }
            }
        }
    }
}
