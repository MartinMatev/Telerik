using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter, IMachine
    {
        private const double INITIAL_FIGTHER_HP = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode) : base(name, attackPoints, defensePoints, INITIAL_FIGTHER_HP)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var baseString = base.ToString();
            StringBuilder output = new StringBuilder(baseString);

            output.AppendLine(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));

            return output.ToString();
        }
    }
}
