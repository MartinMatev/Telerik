using System;
using Cosmetics.Contracts;
using Cosmetics.Common;
using System.Text;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo 
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters { get; private set; }

        public override decimal Price
        {
            get
            {
                return base.Price * this.Milliliters;
            }
            protected set
            {
                base.Price = value;
            }
        }

        public UsageType Usage { get; private set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.Print());

            output.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            output.AppendLine(string.Format("  * Usage: {0}", this.Usage.ToString()));

            return output.ToString();
        }
    }
}
