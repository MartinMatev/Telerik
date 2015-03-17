namespace Point3D
{
    using System;
    public static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double xD = secondPoint.XCord - firstPoint.XCord;
            double yD = secondPoint.YCord - firstPoint.YCord;
            double zD = secondPoint.ZCord - firstPoint.ZCord;

            double distance = Math.Sqrt(Math.Pow(xD, 2) + Math.Pow(yD, 2) + Math.Pow(zD, 2));

            return distance;
        }
    }
}
