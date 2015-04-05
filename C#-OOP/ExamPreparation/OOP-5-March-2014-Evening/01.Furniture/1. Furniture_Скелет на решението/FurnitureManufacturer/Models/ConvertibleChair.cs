namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class ConvertibleChair : Chair, IChair, IConvertibleChair, IFurniture
    {
        private const decimal CONVERTED_HEIGHT = 0.10m;

        private bool isConverted;

        public ConvertibleChair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {

        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
            private set { }
        }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
        }

        public override decimal Height
        {
            get
            {
                if (IsConverted)
                {
                    return CONVERTED_HEIGHT;
                }

                return base.Height;
            }
            protected set
            {
                base.Height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendLine(string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal"));

            return output.ToString().Trim();
        }
    }
}
