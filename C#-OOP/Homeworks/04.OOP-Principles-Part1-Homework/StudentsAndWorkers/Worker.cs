using System;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        static decimal MINIMUM_WAGE = 360;
        private decimal weekSalary;
        private double workHoursPerDay;
        private int workDaysPerWeek;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay, int workDaysPerWeek)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WorkDaysPerWeek = workDaysPerWeek;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < MINIMUM_WAGE)
                {
                    throw new ArgumentException("Salary cannot be less than the minimum wage defined by the LAW!");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0 || value > 12)
                {
                    throw new ArgumentException("Work hours per day cannot be less than 0 or more than 12!");
                }

                this.workHoursPerDay = value;
            }
        }

        public int WorkDaysPerWeek
        {
            get
            {
                return this.workDaysPerWeek;
            }
            set
            {
                if (value < 0 || value > 7)
                {
                    throw new ArgumentException("Work days cannot be less than 0 or more than 7!");
                }

                this.workDaysPerWeek = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = this.weekSalary / (decimal)(this.workHoursPerDay * this.workDaysPerWeek);
            return result;
        }

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}, Money per hour: {2:c}", this.FirstName, this.LastName, MoneyPerHour());
        }
    }
}
