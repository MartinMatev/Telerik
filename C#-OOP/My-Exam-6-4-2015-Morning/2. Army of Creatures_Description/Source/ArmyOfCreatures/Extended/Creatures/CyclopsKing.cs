using System;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Extended.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class CyclopsKing : Creature
    {
        private const int DefaultAttack = 17;
        private const int DefaultDefense = 13;
        private const int DefaultHp = 70;
        private const decimal DefaultDamage = 18m;
        private const int DefaultSkipAttackAdd = 3;
        private const int DefaultDoubleAttackRounds = 4;
        private const int DefaultDoubleDamageRounds = 1;

        public CyclopsKing()
            : base(DefaultAttack, DefaultDefense, DefaultHp, DefaultDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(DefaultSkipAttackAdd));
            this.AddSpecialty(new DoubleAttackWhenAttacking(DefaultDoubleAttackRounds));
            this.AddSpecialty(new DoubleDamage(DefaultDoubleDamageRounds));
        }
    }
}
