using System;

namespace AcademyEcosystem
{
    public class Grass : Plant
    {
        private const int GRASS_SIZE = 2;

        public Grass(Point location)
            : base(location, GRASS_SIZE)
        {

        }

        public override void Update(int time)
        {
            if (this.IsAlive)
            {
                this.Size += time;
            }
            base.Update(time);
        }
    }
}
