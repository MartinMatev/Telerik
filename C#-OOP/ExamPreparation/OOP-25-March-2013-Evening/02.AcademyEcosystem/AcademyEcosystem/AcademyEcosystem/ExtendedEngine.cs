using System;

namespace AcademyEcosystem
{
    public class ExtendedEngine : Engine
    {
        private const string WOLF_TYPE = "wolf";
        private const string LION_TYPE = "lion";
        private const string GRASS_TYPE = "grass";
        private const string BOAR_TYPE = "boar";
        private const string ZOMBIE_TYPE = "zombie";

        protected override void ExecuteBirthCommand(string[] commandWords)
        {
            string organismType = commandWords[1];
            string name = string.Empty;
            Point position = default(Point);

            switch (organismType)
            {
                case WOLF_TYPE:
                    name = commandWords[2];
                    position = Point.Parse(commandWords[3]);
                    Wolf newWolf = new Wolf(name, position);
                    this.AddOrganism(newWolf);
                    break;
                case LION_TYPE:
                    name = commandWords[2];
                    position = Point.Parse(commandWords[3]);
                    Lion newLion = new Lion(name, position);
                    this.AddOrganism(newLion);
                    break;
                case GRASS_TYPE:
                    position = Point.Parse(commandWords[2]);
                    Grass newGrass = new Grass(position);
                    this.AddOrganism(newGrass);
                    break;
                case BOAR_TYPE:
                    name = commandWords[2];
                    position = Point.Parse(commandWords[3]);
                    Boar newBoar = new Boar(name, position);
                    this.AddOrganism(newBoar);
                    break;
                case ZOMBIE_TYPE:
                    name = commandWords[2];
                    position = Point.Parse(commandWords[3]);
                    Zombie newZombie = new Zombie(name, position);
                    this.AddOrganism(newZombie);
                    break;
                default:
                    base.ExecuteBirthCommand(commandWords);
                    break;
            }
        }
    }
}
