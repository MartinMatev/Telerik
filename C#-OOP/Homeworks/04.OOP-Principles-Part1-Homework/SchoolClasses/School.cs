using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolClasses
{
    public class School
    {
        private string schoolName;
        private List<Classes> classes;

        public School(string name)
        {
            this.SchoolName = name;
            this.classes = new List<Classes>();
        }

        public string SchoolName
        {
            get
            {
                return this.schoolName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("School name cannot be null or empty!");
                }

                this.schoolName = value;
            }
        }

        public List<Classes> Classes
        {
            get
            {
                return this.classes;
            }
        }

        public void AddClasses(Classes currentClass)
        {
            this.Classes.Add(currentClass);
        }

        public override string ToString()
        {
            return this.schoolName;
        }
    }
}
