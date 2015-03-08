namespace Bunny
{
    using System;
    using NumeralSystems;
    using NumeralSystems.People;
    using NumeralSystems.People.Students;   
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            AirCraft boing = new AirCraft();
            boing.Fuel = 100M;

            AirCraft battleCruiser = new AirCraft();
            battleCruiser.Fuel = 200M;

            Console.WriteLine("Boing fuel before MOVE: {0}", boing.Fuel);
            Console.WriteLine("Battle Cruiser fuel: {0}", battleCruiser.Fuel);

            boing.Move();
            Console.WriteLine("Boing fuel after MOVE: {0}", boing.Fuel);

            Console.WriteLine(AirCraft.Weight);

            Console.WriteLine("Converted number to decimal: {0}", NumeralSystem.ToDecimal(15M, 2));

            // Call the Point struct with its default constructor (no values need to be passed)
            Point pt = new Point();
            pt.X = 5;
            pt.Y = 10;

            // Call the Point struct with the constructor we implemented 
            Point secondPoint = new Point(1, 2, 3);
            Console.WriteLine("X = {0}, Y = {1}, Z = {2}", secondPoint.X, secondPoint.Y, secondPoint.Z);

            secondPoint.Add(17, 18, 35);
            Console.WriteLine("NEW VALUES: X = {0}, Y = {1}, Z = {2}", secondPoint.X, secondPoint.Y, secondPoint.Z);

            Console.WriteLine("Calculation static method result: {0}", Point.Calculate(pt, secondPoint));

            List<int> listOfIntegers = new List<int>();
            List<string> listOfStrings = new List<string>();

            // Пример как една функция работи с Generic<T> и приема няколко типове данни
            listOfIntegers.Add(25);
            listOfStrings.Add("string");

            // Шаблон
            List<object> list = new List<object>();
        }
    }
}
