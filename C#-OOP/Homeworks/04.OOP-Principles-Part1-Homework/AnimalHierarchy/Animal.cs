using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalHierarchy
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private Gender sex;

        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
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
                if (value < 0 || value > 140)
                {
                    throw new ArgumentException("Your animal might be dead");
                }

                this.age = value;
            }
        }

        public Gender Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public virtual void ProduceSound()
        {
            Console.Write("My name is {0}", this.Name);
        }

        public static double AverageAge(params Animal[] collection)
        {
            return collection.Average(x => x.Age);
        }
    }
}
