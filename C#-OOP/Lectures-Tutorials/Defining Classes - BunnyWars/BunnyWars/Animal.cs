namespace Animal
{
    using System;
    public abstract class Animal // Означава, че този клас не може да се инициализира /Не може да се създаде обект от Animal/
    {
        private string name;


        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("Name must be longer than 4 symbols");
                }

                this.name = value;
            }
        }

        public int Health { get; set; }
    }
}
