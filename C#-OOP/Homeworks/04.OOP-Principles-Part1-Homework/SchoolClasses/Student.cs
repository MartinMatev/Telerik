using System;

namespace SchoolClasses
{
    public class Student: Person
    {
        // Guid is used for generating UNIQUE 128bit values
        private Guid uniqueClassNumber;
        public Student(string name, int age, Guid uniqueClassNumber)
            : base(name, age)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public Student(string name, int age, Guid uniqueClassNumber, string comment)
            : base(name, age)
        {
            this.UniqueClassNumber = uniqueClassNumber;
            this.Comment = comment;
        }

        public Guid UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }
            set
            {
                this.uniqueClassNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name = {0}, UniqueNum = {1}", this.Name, this.UniqueClassNumber);
        }
    }
}
