using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Cosmetics.Contracts;
using Cosmetics.Common;


namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        private const int MinimumCategoryLength = 2;
        private const int MaximumCategoryLength = 15;

        private string name;
        private IList<IProduct> cosmeticsList;

        public Category(string name)
        {
            this.Name = name;
            this.cosmeticsList = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                //Validator.CheckIfStringIsNullOrEmpty(name, "Category name cannot be null or empty!");
                Validator.CheckIfStringLengthIsValid(value, MaximumCategoryLength, MinimumCategoryLength, string.Format("Category name must be between {0} and {1} symbols long!", MinimumCategoryLength, MaximumCategoryLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, "Cannot add a null cosmetic to the list!");
            this.cosmeticsList.Add(cosmetics);       
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            bool doesContain = cosmeticsList.Contains(cosmetics);
            if (doesContain)
            {
                cosmeticsList.Remove(cosmetics);
            }
            else
            {
                throw new ArgumentOutOfRangeException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder();
            var sortedCosmeticList = cosmeticsList.OrderBy(o => o.Brand).ThenByDescending(t => t.Price);

            output.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name, cosmeticsList.Count, cosmeticsList.Count == 1 ? "product" : "products"));

            foreach (var product in sortedCosmeticList)
            {
                output.AppendLine(product.ToString().Trim());
            }

            return output.ToString().Trim();
        }
    }
}
