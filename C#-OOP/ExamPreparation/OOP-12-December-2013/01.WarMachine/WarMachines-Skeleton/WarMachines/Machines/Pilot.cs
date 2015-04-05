namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WarMachines.Interfaces;
    using WarMachines.Common;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Pilot name cannot be null or empty");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfNull(machine, "Null machines cannot be added!");
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines = this.machines
                                     .OrderBy(x => x.HealthPoints)
                                     .ThenBy(x => x.Name);

            StringBuilder output = new StringBuilder();

            var machineNumber = this.machines.Count > 0 ? 
                this.machines.Count.ToString() : "no";

            var singularOrPlural = this.machines.Count == 1 ? "machine" : "machines";

            output.AppendLine(string.Format("{0} - {1} {2}", this.Name, machineNumber, singularOrPlural));

            foreach (var machine in sortedMachines)
            {
                output.AppendLine(machine.ToString());
            }

            return output.ToString().Trim();
        }
    }
}
