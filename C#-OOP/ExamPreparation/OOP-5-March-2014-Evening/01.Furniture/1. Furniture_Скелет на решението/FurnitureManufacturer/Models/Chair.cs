namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System.Text;
    public class Chair : Furniture, IChair, IFurniture
    {
        public Chair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }
        public int NumberOfLegs { get; private set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendLine(string.Format(", Legs: {0}", this.NumberOfLegs));

            return output.ToString().Trim();
        }
    }
}
