namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;
    using WarMachines.Common;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Machine name cannot be null or empty");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                Validator.CheckIfNull(value, "Pilot cannot be null");
                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get { return new List<string>(this.targets); }
        }

        public void Attack(string target)
        {
            Validator.CheckIfStringIsNullOrEmpty(target, "Target name cannot be null");
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(string.Format("- {0}", this.Name));
            output.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            output.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            output.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            output.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));

            if (this.Targets.Count == 0)
            {
                output.AppendLine(" *Targets: None");
            }
            else
            {
                output.AppendLine(string.Format(" *Targets: {0}", string.Join(", ", this.Targets)));
            }

            return output.ToString();
        }
    }
}
