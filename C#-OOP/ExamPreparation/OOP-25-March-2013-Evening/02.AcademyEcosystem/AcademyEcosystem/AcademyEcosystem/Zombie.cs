using System;

namespace AcademyEcosystem
{
    public class Zombie : Animal
    {
        private const int ZOMBIE_SIZE = 0;
        private const int MEAT_UNITS = 10;

        public Zombie(string name, Point position)
            : base(name, position, ZOMBIE_SIZE)
        {

        }
        public override int GetMeatFromKillQuantity()
        {
            return MEAT_UNITS;
        }
    }
}
