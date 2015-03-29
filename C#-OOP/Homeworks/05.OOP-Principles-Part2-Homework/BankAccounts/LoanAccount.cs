using System;

namespace BankAccounts
{
    // Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
    public class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal InterestCalculations(int months)
        {
            if (this.Customer is Individuals)
            {
                months -= 3;
            }
            else if (this.Customer is Companies)
            {
                months -= 2;
            }

            if (months < 0)
            {
                return 0;
            }

            return base.InterestCalculations(months);
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
