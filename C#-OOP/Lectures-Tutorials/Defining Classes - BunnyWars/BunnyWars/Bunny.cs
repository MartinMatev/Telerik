
namespace BunnyWars
{
    using System;
    using Animal;
    public class Bunny : Animal
    {
        public static int NumberOfLegs = 4; // Означава, че е общо САМО за зайците, вика се с иметоНаКласа. (i.e Bunny.NumberOfLegs)

        private const int INITIAL_HEALTH = 100;
        private const int INITIAL_CARROTS = 0;

        private ColorType color;
        private ulong carrotsCount;

        // Constructor // takes only name
        public Bunny(string bunnyName)
        {
            base.Name = bunnyName;
            this.Health = INITIAL_HEALTH;
            this.carrotsCount = INITIAL_CARROTS;
            this.IsRetired = false;
        }

        // Second constructor // takes name and color // override // :this(bunnyName) calls the other constructor
        public Bunny(string bunnyName, ColorType playerColor) : this(bunnyName)
        {
            this.color = playerColor;
        }

        // Методи, които може да се викат от други класове /public са все пак/
        public void ChangeColor(ColorType newColor)
        {
            this.Color = newColor;  // this.Color вика СВОЙСТВОТО, което от своя страна работи с полето !!!
        }

        public ulong AddCarrots(ulong carrots)
        {
            this.carrotsCount += carrots;

            return this.carrotsCount;
        }

        // Свойства - служат за конфигурация на полетата /и.е четене и променяне на наличните полета/


        public ColorType Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (value != ColorType.Red && value != ColorType.Cyan)
                {
                    throw new ArgumentException("Color must be Red or Cyan");
                }
                this.color = value;
            }
        }

        // Създавайки СВОЙСТВО без поле към което да гледа, то си създава автоматично private такова
        // Използва се ако НЯМА нужда от валидации на Set-a !

        public bool IsRetired { get; private set; }

        public void Retire()
        {
            if (this.Health < 0)
            {
                this.IsRetired = true;
            }
        }

        public int DamageTaken
        {
            get
            {
                if (this.Health < 0)
                {
                    return INITIAL_HEALTH;
                }

                int damage = INITIAL_HEALTH - this.Health;

                return damage;
            }
        }

        // ToString override
        public override string ToString()
        {
            return base.Name + " " + this.Health;
        }
    }
}
