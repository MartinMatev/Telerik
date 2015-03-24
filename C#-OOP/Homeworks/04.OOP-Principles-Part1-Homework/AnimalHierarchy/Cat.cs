using System;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Gender sex, string breed)
            : base(name, age, sex)
        {
            this.Breed = breed;
        }
        public string Breed { get; set; }

        public override void ProduceSound()
        {
            base.ProduceSound();
            Console.WriteLine(", Miao-Miao!");
        }
    }
}
