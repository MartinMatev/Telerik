using System;

namespace BankAccounts
{
    public abstract class Customer
    {
        private string name;
        private string address;
        private string phone;

        public Customer(string name, string address, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public string Name {
            get 
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Address cannot be null or empty");
                }

                this.address = value;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Phone number cannot be null or empty");
                }

                this.phone = value;
            }
        }

    }
}
