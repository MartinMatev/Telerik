using System;
using ArmyOfCreatures.Logic.Specialties;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreatures.Extended.Specialties
{
    public class DoubleAttackWhenAttacking : Specialty
    {
        private int numberOfRounds;

        public DoubleAttackWhenAttacking(int numberOfRounds)
        {
            this.NumberOfRounds = numberOfRounds;
        }

        public int NumberOfRounds
        {
            get
            {
                return this.numberOfRounds;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of rounds cannot be a negative number!");
                }

                this.numberOfRounds = value;
            }
        }

        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.NumberOfRounds <= 0)
            {
                return;
            }

            attackerWithSpecialty.CurrentAttack *= 2;
            this.NumberOfRounds--;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.GetType().Name, this.NumberOfRounds);
        }
    }
}
