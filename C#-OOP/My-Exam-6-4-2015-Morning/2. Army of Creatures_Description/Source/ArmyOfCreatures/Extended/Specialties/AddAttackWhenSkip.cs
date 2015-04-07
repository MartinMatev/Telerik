using System;
using ArmyOfCreatures.Logic.Specialties;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreatures.Extended.Specialties
{
    public class AddAttackWhenSkip : Specialty
    {
        private const int MinAttackValue = 1;
        private const int MaxAttackValue = 10;

        private int addAttackValue;

        public AddAttackWhenSkip(int addAttackValue)
        {
            this.AddAttackValue = addAttackValue;
        }

        public int AddAttackValue
        {
            get
            {
                return this.addAttackValue;
            }
            set
            {
                if (value < MinAttackValue || value > MaxAttackValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Attack value must be between {0} and {1} inclusive!", MinAttackValue, MaxAttackValue));
                }

                this.addAttackValue = value;
            }
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.addAttackValue;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.GetType().Name, this.addAttackValue);
        }
    }
}
