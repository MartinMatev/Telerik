namespace BankAccounts
{
    public class Companies : Customer
    {
        public Companies(string name, string address, string phone, ulong bulstat)
            : base(name, address, phone)
        {
            this.Bulstat = bulstat;
        }

        public ulong Bulstat { get; set; }
    }
}
