namespace BunnyWars
{
    using System;
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Вика се първоначално всеки AirCraft с нулеви кординати
        public Coordinates() : this(0, 0) // Sets the coordinates to 0 if invoked with NO VALUES SENT
        {

        }

        // Следващият път се вика от Move() като му се задават кординатите на които да се премести
        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
