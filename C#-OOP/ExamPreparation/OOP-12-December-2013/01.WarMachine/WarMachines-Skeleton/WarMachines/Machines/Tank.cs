using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank, IMachine
    {
        private const double INITIAL_TANK_HP = 100;
        private const bool INITAL_DEFENSE_MODE = true;
        private const int CHANGE_ATTACK_POINTS = 40;
        private const int CHANGE_DEFENSE_POINTS = 30;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints - CHANGE_ATTACK_POINTS, defensePoints + CHANGE_DEFENSE_POINTS, INITIAL_TANK_HP)
        {
            this.DefenseMode = INITAL_DEFENSE_MODE;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;

            if (this.DefenseMode)
            {
                this.AttackPoints -= CHANGE_ATTACK_POINTS;
                this.DefensePoints += CHANGE_DEFENSE_POINTS;
            }
            else
            {
                this.AttackPoints += CHANGE_ATTACK_POINTS;
                this.DefensePoints -= CHANGE_DEFENSE_POINTS;
            }
        }

        public override string ToString()
        {
            var baseString = base.ToString();
            StringBuilder output = new StringBuilder(baseString);

            output.AppendLine(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));

            return output.ToString().Trim();
        }
    }
}
