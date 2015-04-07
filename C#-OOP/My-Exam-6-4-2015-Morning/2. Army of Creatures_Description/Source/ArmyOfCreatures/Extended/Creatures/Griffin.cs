using System;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class Griffin : Creature
    {
        private const int DefaultAttack = 8;
        private const int DefaultDefense = 8;
        private const int DefaultHp = 25;
        private const decimal DefaultDamage = 4.5m;
        private const int DefaultDefendingDefense = 5;
        private const int DefaultSkipDefense = 3;

        public Griffin()
            : base(DefaultAttack, DefaultDefense, DefaultHp, DefaultDamage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(DefaultDefendingDefense));
            this.AddSpecialty(new AddDefenseWhenSkip(DefaultSkipDefense));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
