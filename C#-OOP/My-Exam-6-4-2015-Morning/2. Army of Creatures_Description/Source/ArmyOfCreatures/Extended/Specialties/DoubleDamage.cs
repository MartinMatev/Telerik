using System;
using ArmyOfCreatures.Logic.Specialties;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreatures.Extended.Specialties
{
    public class DoubleDamage : Specialty
    {
        private int numberOfRounds;
        public DoubleDamage(int numberOfRounds)
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
                    throw new ArgumentOutOfRangeException("Rounds cannot be a negative number!");
                }

                if (value > 10)
                {
                    throw new ArgumentOutOfRangeException("Rounds count cannot be more than 10!");
                }

                this.numberOfRounds = value;
            }
        }

        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender, decimal currentDamage)
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
                return currentDamage;
            }

            NumberOfRounds--;
            return currentDamage * 2M;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.GetType().Name, this.NumberOfRounds);
        }
    }
}
