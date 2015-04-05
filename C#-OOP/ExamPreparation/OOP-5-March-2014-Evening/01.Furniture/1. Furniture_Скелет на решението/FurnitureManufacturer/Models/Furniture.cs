namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    using FurnitureManufacturer.Common;
    public abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            this.Model = model;
            this.MatType = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                Validator.CheckIfNullOrEmpty(value, "Model cannot be null or empty!");
                Validator.CheckIfLessThanN(value, 3, "Model lenght cannot be less than 3");

                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material;
            }
            private set
            {
                Validator.CheckIfNullOrEmpty(value, "Material cannot be null or empty!");
                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validator.CheckIfValidValue(value, "Price cannot be <= 0");
                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                Validator.CheckIfValidValue(value, "Height cannot be <= 0");
                this.height = value;
            }
        }

        public MaterialType MatType { get; private set; }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.MatType, this.Price, this.Height);
        }
    }
}
