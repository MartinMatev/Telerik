using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Tank : Unit
    {
        private const int BASE_HEALTH = 20;
        private const int BASE_POWER = 25;
        private const int BASE_AGGRESSION = 25;

        public Tank(string id)
            : base(id, UnitClassification.Mechanical , BASE_HEALTH, BASE_POWER, BASE_AGGRESSION)
        {

        }
    }
}
