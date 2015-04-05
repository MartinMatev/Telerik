namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    class AdjustableChair : Chair, IAdjustableChair, IChair, IFurniture
    {
        public AdjustableChair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {

        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
