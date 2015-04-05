namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FurnitureManufacturer.Common;
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfNullOrEmpty(value, "Company name cannot be null of empty!");
                Validator.CheckIfLessThanN(value, 5, "Company name length cannot be less than 5");

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {
                Validator.CheckIfNullOrEmpty(value, "Reg num cannot be null");

                if (value.Length != 10 || !(Validator.ContainsOnlyDigits(value)))
                {
                    throw new ArgumentException("Reg num must be exaclty 10 symbols and can contain only digits!");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (furnitures.Count > 0)
            {
                this.furnitures.Remove(furniture);
            }
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("{0} - {1} - {2} {3}", this.Name,
            this.RegistrationNumber,
            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
            this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            foreach (var furniture in this.Furnitures.OrderBy(x => x.Price).ThenBy(y => y.Model))
            {
                output.AppendLine(furniture.ToString());
            }

            return output.ToString().Trim();
        }
    }
}
