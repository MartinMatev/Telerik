using System;

namespace AcademyEcosystem
{
    public class Wolf : Animal, ICarnivore
    {
        private const int WOLF_SIZE = 4;
        public Wolf(string name, Point position)
            : base(name, position, WOLF_SIZE)
        {

        }
        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size || animal.State == AnimalState.Sleeping)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;          
        }
    }
}
