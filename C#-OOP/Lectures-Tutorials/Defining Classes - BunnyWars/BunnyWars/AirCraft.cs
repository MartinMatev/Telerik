namespace BunnyWars
{
    using System;

    public class AirCraft
    {
        public static double CalculateDistance(AirCraft first, AirCraft second)
        {
            return Math.Sqrt(
                (first.Coordinates.X - second.Coordinates.X) * (first.Coordinates.X - second.Coordinates.X) +
                (first.Coordinates.Y - second.Coordinates.Y) * (first.Coordinates.Y - second.Coordinates.Y));
        }

        public static int Speed()
        {
            return 100;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public Bunny Pilot { get; private set; }

        public Coordinates Coordinates { get; set; }

        public AirCraft(Bunny bunny, int damage)
        {
            this.Pilot = bunny;
            this.Damage = damage;
            this.Coordinates = new Coordinates();
        }

        public void Attack(AirCraft target)
        {
            if (this.Pilot.Color == target.Pilot.Color)
            {
                return;
            }

            target.Pilot.Health -= this.Damage;
        }

        public void Move(Coordinates coord)
        {
            this.Coordinates.X = coord.X;
            this.Coordinates.Y = coord.Y;
        }
    }
}
