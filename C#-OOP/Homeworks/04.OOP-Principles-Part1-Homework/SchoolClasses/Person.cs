using System;

namespace SchoolClasses
{
    public class Person : IComment
    {
        private string name;
        private int age;
        private string comment;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string comment) : this(name, age)
        {
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be a null value!");
                }

                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (age < 0 || age > 140)
                {
                    throw new ArgumentException("Age must be > 0 and < 140!");
                }

                this.age = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
