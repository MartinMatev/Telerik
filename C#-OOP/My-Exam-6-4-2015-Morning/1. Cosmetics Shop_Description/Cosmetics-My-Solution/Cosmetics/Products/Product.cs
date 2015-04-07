using System;
using System.Text;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 10;
        private const int MinBrandLength = 2;
        private const int MaxBrandLength = 10;

        private string name;
        private string brand;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                //Validator.CheckIfNull(value, "Product cannot be null");
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, string.Format("Product name must be between {0} and {1} symbols long!", MinNameLength, MaxNameLength));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                //Validator.CheckIfNull(value, "Product cannot be null");
                Validator.CheckIfStringLengthIsValid(value, MaxBrandLength, MinNameLength, string.Format("Product brand must be between {0} and {1} symbols long!", MinBrandLength, MaxBrandLength));

                this.brand = value;
            }
        }

        public virtual decimal Price { get; protected set; }

        public GenderType Gender { get; protected set; }

        public string Print()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            output.AppendLine(string.Format("  * Price: ${0}", this.Price));
            output.AppendLine(string.Format("  * For gender: {0}", this.Gender.ToString()));

            return output.ToString();
        }
    }
}
