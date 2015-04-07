using System;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Extended.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class WolfRaider : Creature
    {
        private const int DefaultAttack = 8;
        private const int DefaultDefense = 5;
        private const int DefaultHp = 10;
        private const decimal DefaultDamage = 3.5m;
        private const int DefaultDoubleDamageRounds = 7;

        public WolfRaider()
            : base(DefaultAttack, DefaultDefense, DefaultHp, DefaultDamage)
        {
            this.AddSpecialty(new DoubleDamage(DefaultDoubleDamageRounds));
        }
    }
}
