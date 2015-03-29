using System;

namespace BankAccounts
{
    // Deposit accounts have no interest if their balance is positive and less than 1000.
    public class DepositAccount : Account, IDeposit, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal InterestCalculations(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000m)
            {
                return 0m;
            }

            return base.InterestCalculations(months);
        }

        public void DepositMoney(decimal moneyAmount)
        {
            TransactionCheck(moneyAmount);

            this.Balance += moneyAmount;
        }

        public void MoneyWithdraw(decimal moneyAmount)
        {
            TransactionCheck(moneyAmount);
            this.Balance -= moneyAmount;
        }

        private static void TransactionCheck(decimal moneyAmount)
        {
            if (moneyAmount < 0)
            {
                throw new ArgumentException("You cannot deposit/withdraw a negative value! Go home, you are drunk.");
            }
        }


    }
}
