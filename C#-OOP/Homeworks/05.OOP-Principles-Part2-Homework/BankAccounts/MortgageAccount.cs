using System;

namespace BankAccounts
{
    // Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
    public class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal InterestCalculations(int months)
        {
            if (this.Customer is Individuals)
            {
                if (months <= 12)
                {
                    return base.InterestCalculations((int)(months * 0.5));
                }
                else
                {
                    decimal result = 0.5m * base.InterestCalculations(12);
                    result += base.InterestCalculations(months - 12);
                    return result;
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0m;
                }
                else
                {
                    months -= 6;
                    return base.InterestCalculations(months);
                }
            }
        }

        public void DepositMoney(decimal moneyAmount)
        {
            if (moneyAmount < 0)
            {
                throw new ArgumentException("You cannot deposit a negative value! Go home, you are drunk.");
            }

            this.Balance += moneyAmount;
        }
    }
}
