
namespace BunnyWars
{
    using System;
    using System.Collections.Generic;
    using Animal;

    class BunnyWars
    {
        static void Main()
        {
            Bunny desiBunny = new Bunny("Desi");
            Bunny martiBunny = new Bunny("Marty", ColorType.Cyan);

            martiBunny.ChangeColor(ColorType.Red);
            ulong currentDesiCarrots = desiBunny.AddCarrots(100);
            ulong currentMartiCarrots = martiBunny.AddCarrots(350);

            ColorType martyOldColor = martiBunny.Color;
            ColorType martyNewColor = martiBunny.Color = ColorType.Cyan;

            martiBunny.Health = 1337;

            
            Console.WriteLine("Old color = {0}", martyOldColor);
            Console.WriteLine("New color = {0}", martyNewColor);
            Console.WriteLine("Health: {0}", martiBunny.Health);
            Console.WriteLine("Is dead: {0}", martiBunny.IsRetired);

            martiBunny.Health -= 1237;
            martiBunny.Retire();

            Console.WriteLine("Is dead: {0}", martiBunny.IsRetired);

            Bunny.NumberOfLegs = 12;

            Console.WriteLine("Number of legs: {0}", Bunny.NumberOfLegs);


            List<Bunny> bunnies = new List<Bunny>();
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                Bunny currentBunny = new Bunny(new string((char)i, 5));
                currentBunny.Health = rand.Next(0, 100);
                bunnies.Add(currentBunny);
            }

            //foreach (var bunny in bunnies)
            //{
            //    Console.WriteLine("{0} - {1}", bunny.Name, bunny.Health);
            //}

            var martiAndDesi = new List<Bunny>
            {
                martiBunny,
                desiBunny
            };

            foreach (var bunny in martiAndDesi)
            {
                Console.WriteLine(bunny.Name);
            }

            AirCraft firstPlayer = new AirCraft(martiBunny, 50);
            AirCraft secondPlayer = new AirCraft(desiBunny, 45);

            secondPlayer.Attack(firstPlayer);

            Console.WriteLine("Health of 1st player after the attack: {0}", firstPlayer.Pilot.Health);
            Console.WriteLine("The 1st player has taken {0} damage!", martiBunny.DamageTaken);

            Console.WriteLine("Speed of ALL the aircrafts: {0}", AirCraft.Speed());

            firstPlayer.Move(new Coordinates(15, 20));
            secondPlayer.Move(new Coordinates(25, 40));

            double distance = AirCraft.CalculateDistance(firstPlayer, secondPlayer);

            Console.WriteLine("The distance between the AirCrafts(P1 && P2): {0}", distance);

            ColorType colorType = ColorType.Cyan;
            Console.WriteLine("ColorType = {0}", colorType);

            Bunny thirdWheelBunny = new Bunny("Baeeee");

            Console.WriteLine(thirdWheelBunny.ToString());

            object bunny2 = new Bunny("sahhjdasj");
            Bunny nqkvoBunny = bunny2 as Bunny;
            Console.WriteLine("Object to Bunny cast: {0}", nqkvoBunny.Name);

            if (martiBunny is Animal)
            {
                Console.WriteLine("Marti is indeed an Animal !");
            }
        }
    }
}
