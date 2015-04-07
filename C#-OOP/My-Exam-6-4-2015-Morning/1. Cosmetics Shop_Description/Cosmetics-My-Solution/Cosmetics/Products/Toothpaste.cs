using System;
using System.Collections.Generic;
using Cosmetics.Contracts;
using Cosmetics.Common;
using System.Text;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste
    {
        private const int IngredientMinLength = 4;
        private const int IngredientMaxLength = 12;

        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredients = new List<string>(ingredients);
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", ingredients);
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Ingredient name cannot be null or empty");
                Validator.CheckIfStringLengthIsValid(value, IngredientMaxLength, IngredientMinLength, string.Format("Each ingredient must be between {0} and {1} symbols long!", IngredientMinLength, IngredientMaxLength));

                this.ingredients.Add(value);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.Print());
            output.AppendLine(string.Format("  * Ingredients: {0}", this.Ingredients));

            return output.ToString();
        }
    }
}
