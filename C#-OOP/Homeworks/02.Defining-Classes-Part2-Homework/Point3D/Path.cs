namespace Point3D
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class Path : IEnumerable<Point3D>
    {
        // Create a list of Points
        public List<Point3D> PointsSequence { get; set; }

        // constructors
        public Path(List<Point3D> collection)
        {
            this.PointsSequence = collection;
        }

        public Path()
        {
            
        }

        // Both method below are REQUIRED to be implemented by the IEnumerable interface
        // They enumerater the LIST of POINTS, so they can be foreach looped later
        public IEnumerator<Point3D> GetEnumerator()
        {
            return PointsSequence.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // ToString() override
        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.PointsSequence);
        }
    }

    public static class PathStorage
    {
        // Appends Path Lines in the file at the filePath location
        public static void SavePoints(List<Point3D> collection, string filePath)
        {
            foreach (Point3D point in collection)
            {
                File.AppendAllText(filePath, point.ToString() + Environment.NewLine);
            }
        }

        public static void LoadPoints(string filePath)
        {
            Path newPath = new Path(new List<Point3D>());

            string[] points = File.ReadAllText(filePath).Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine("\nBelow are the coordinates, read from the text file:");
            for (int i = 0; i < points.Length; i++)
			{
                int[] coords = points[i].Split(' ').Select(int.Parse).ToArray();

                newPath = new Path(new List<Point3D>
                {
                    new Point3D { XCord = coords[0], YCord = coords[1], ZCord = coords[2]}
                });

                Console.WriteLine(newPath.ToString());
			}
        }

    }
}
