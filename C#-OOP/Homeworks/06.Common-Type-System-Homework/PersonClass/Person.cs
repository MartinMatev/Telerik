using System;

namespace PersonClass
{
    class Person
    {
        private readonly string NOT_FOUND_MESSAGE = "Age not found";

        private string name;
        private byte? age;


        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be an empty or null value");
                }

                this.name = value;
            }
        }
        public byte? Age {
            get 
            {
                return this.age;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be a negative number");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age == null ? NOT_FOUND_MESSAGE : this.Age.ToString());
        }
    }
}
