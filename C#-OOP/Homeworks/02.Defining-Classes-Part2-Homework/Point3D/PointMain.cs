namespace Point3D
{
    using System;
    using System.Collections.Generic;
    public class PointMain
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(2, 3, 4);
            Point3D seconPoint = new Point3D(5, 6, 7);

            // Print out the said object instance of Point3D
            Console.WriteLine("Coords of first point");
            Console.WriteLine(firstPoint);
            Console.WriteLine("Coords of second point");
            Console.WriteLine(seconPoint);

            // Print out pointO (0, 0, 0) coords
            Console.WriteLine("\nPoint O coords: ");
            Console.WriteLine(Point3D.PointO);

            // Print out calculated distance of 2 points
            Console.WriteLine("\nDistance between first and second points");
            Console.WriteLine(Distance.CalculateDistance(firstPoint, seconPoint));

            // Create a collection of Points and add it to the object of the class Path            
            Path newCollection = new Path(new List<Point3D>
            {
                new Point3D {XCord = 2, YCord = 3, ZCord = 4},
                new Point3D {XCord = 1, YCord = 33, ZCord = 7},
                new Point3D {XCord = 4, YCord = -3, ZCord = 13}
            });

            // Foreach loop the collection, thanks to the IEnumerator
            Console.WriteLine("\nContent of the Path collection of points:");
            foreach (Point3D point in newCollection)
            {
                Console.WriteLine(point);
            }

            // Save point paths to a file
            PathStorage.SavePoints(new List<Point3D> 
            { 
                new Point3D { XCord = 1, YCord = 2, ZCord = 3 },
                new Point3D { XCord = 1, YCord = 33, ZCord = 7}
                }, "../../save.txt");

            // Load point path from a file
            PathStorage.LoadPoints("../../load.txt");
        }
    }
}
