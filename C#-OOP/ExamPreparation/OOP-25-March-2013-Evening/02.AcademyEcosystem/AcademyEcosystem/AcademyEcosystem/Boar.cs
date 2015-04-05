using System;

namespace AcademyEcosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int BOAR_SIZE = 4;
        private const int BITE_SIZE = 2;

        public Boar(string name, Point position)
            : base(name, position, BOAR_SIZE)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;  
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(BITE_SIZE);
            }

            return 0;
        }
    }
}
