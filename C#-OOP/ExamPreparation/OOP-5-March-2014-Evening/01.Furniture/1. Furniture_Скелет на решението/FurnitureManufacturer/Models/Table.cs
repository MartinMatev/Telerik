namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Common;
    using FurnitureManufacturer.Interfaces;
    using System.Text;
    public class Table : Furniture, ITable, IFurniture
    {

        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width) : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length { get; private set; }

        public decimal Width { get; private set; }

        public decimal Area
        {
            get
            {
                return CalculateArea();
            }
        }

        private decimal CalculateArea()
        {
            return this.Length * this.Width;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendLine(string.Format("Width: {0}, Area: {1}", this.Width, this.Area));

            return output.ToString().Trim();
        }
    }
}
