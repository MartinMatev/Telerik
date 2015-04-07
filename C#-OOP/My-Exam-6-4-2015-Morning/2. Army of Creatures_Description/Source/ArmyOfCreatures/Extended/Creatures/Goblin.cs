using System;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class Goblin : Creature
    {
        private const int DefaultAttack = 4;
        private const int DefaultDefense = 2;
        private const int DefaultHp = 5;
        private const decimal DefaultDamage = 1.5m;

        public Goblin()
            : base(DefaultAttack, DefaultDefense, DefaultHp, DefaultDamage)
        {

        }
    }
}
