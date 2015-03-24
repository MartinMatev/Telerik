using System;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 0 || value > 6)
                {
                    throw new ArgumentException("Grad cannot be less than 0 and more than 6");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}, Grade: {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
