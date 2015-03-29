namespace BankAccounts
{
    public class Individuals : Customer
    {

        public Individuals(string name, string address, string phone, ulong egn)
            : base(name, address, phone)
        {
            this.Egn = egn;
        }

        public ulong Egn { get; set; }
    }
}
