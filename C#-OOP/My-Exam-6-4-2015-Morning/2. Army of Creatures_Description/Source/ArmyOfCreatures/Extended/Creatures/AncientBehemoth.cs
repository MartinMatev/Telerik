using System;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class AncientBehemoth : Creature
    {
        private const int DefaultAttack = 19;
        private const int DefaultDefense = 19;
        private const int DefaultHp = 300;
        private const decimal DefaultDamage = 40m;
        private const int ReduceDefensePercent = 80;
        private const int DefenseWhenDefending = 5;

        public AncientBehemoth()
            : base(DefaultAttack, DefaultDefense, DefaultHp, DefaultDamage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(ReduceDefensePercent));
            this.AddSpecialty(new DoubleDefenseWhenDefending(DefenseWhenDefending));
        }
    }
}
