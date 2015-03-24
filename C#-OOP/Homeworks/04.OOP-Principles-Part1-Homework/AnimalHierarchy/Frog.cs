using System;

namespace AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Gender sex, string species)
            : base(name, age, sex)
        {
            this.Species = species;
        }

        public string Species { get; set; }

        public override void ProduceSound()
        {
            base.ProduceSound();
            Console.WriteLine(", Ribbit-ribbit!");
        }
    }
}
