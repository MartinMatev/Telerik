namespace Bunny
{
    using System;
    public class AirCraft
    {
        // Статик свойствата НЕ МОЖЕ да се достъпват от обекти на класа, а САМО от самия клас.
        // i.e AirCraft.Weight; а НЕ boing.Weight. Static отговарят за всички, а не за всяка една инстанция
        public static int Weight
        {
            get
            {
                return 250;
            }
        }

        public decimal Fuel { get; set; }

        public AirCraft()
        {
            this.Fuel = 200M;
        }

        public void Move()
        {
            this.Fuel -= 10M;
        }
    }
}
