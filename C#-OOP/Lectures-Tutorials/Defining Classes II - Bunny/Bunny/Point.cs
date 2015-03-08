namespace Bunny
{
    using System;
    public struct Point
    {
        public static decimal Calculate(Point first, Point second)
        {
            return (first.X + first.Y + first.Z) * (first.X + first.Y + first.Z);
        }
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Point(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void Add(int addX, int addY, int addZ)
        {
            this.X += addX;
            this.Y += addY;
            this.Z += addZ;
        }
    }
}
