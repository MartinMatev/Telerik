namespace AnonymousTypes
{
    using System;
    using System.Collections.Generic;
    class AnonymousTypes
    {
        public static void Main()
        {
            var point = new
            {
                X = 10,
                Y = 100,
                Coordinates = new List<int> { 100, 300 },
                Name = "Pesho"
            };

            var anotherPoint = new
            {
                X = 20,
                Y = 250,
                Coordinates = new List<int> { 127, 1337 },
                Name = "Pesho"
            };

            Console.WriteLine("X = {0}, Y = {1}", point.X, point.Y);

            var list = point.Coordinates;
            list.Add(500);

            foreach (var number in list)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(point.Name);

            var collection = new[]
            {
                4, 6, 10
            };

            foreach (var number in collection)
            {
                Console.WriteLine(number);
            }

            var collectionOfObjects = new[]
            {
                new List<string> {"Pesho"},
                new List<string> {"Gosho"}
            };

            var collectionOfAnnTypes = new[]
            {
                new {X = 10, Y = 20},
                new {X = 100, Y = 200}
            };

            foreach (var obj in collectionOfAnnTypes)
            {
                Console.WriteLine(obj.X);
            }
        }
    }
}
