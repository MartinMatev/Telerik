using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolClasses
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines;
        public Teacher(string name, int age)
            : base(name, age)
        {
            this.disciplines = new List<Discipline>();
        }

        public void AddDisciplines(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public List<Discipline> GetDisciplines()
        {
            return this.disciplines.ToList();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
