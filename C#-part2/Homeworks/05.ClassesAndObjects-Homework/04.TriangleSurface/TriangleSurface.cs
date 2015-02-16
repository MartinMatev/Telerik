using System;

/*
 * Write methods that calculate the surface of a triangle by given:
 * 
 * Side and an altitude to it;
 * Three sides;
 * Two sides and an angle between them;
 * Use System.Math.
 */
class TriangleSurface
{
    static void Main()
    {
        decimal sideA = 5m;
        decimal sideB = 5m;
        decimal sideC = 7m;
        decimal angleAB = 90m;
        decimal heigth = 5m;
        SideAndHeight(sideA, heigth);
        ThreeSides(sideA, sideB, sideC);
        SidesAndAngle(sideA, sideB, angleAB);

    }

    private static void SidesAndAngle(decimal sideB, decimal sideC, decimal angleBC)
    {
        // Using the "side angle side" (SAS) method
        angleBC *= (decimal)Math.PI / 180.0m;
        decimal area = ((sideB * sideC) * (decimal)Math.Sin((double)angleBC)) / 2;
        PrinResult(area, "Side angle side");
    }

    private static void ThreeSides(decimal sideA, decimal sideB, decimal sideC)
    {
        // Using Heron's Formula
        decimal halfP = (sideA + sideB + sideC) / 2;
        decimal area = (decimal)Math.Sqrt((double)(halfP * (halfP - sideA) * (halfP - sideB) * (halfP-sideC)));
        PrinResult(area, "Three sides");
    }

    private static void SideAndHeight(decimal sideA, decimal heigth)
    {
        PrinResult(((sideA * heigth) / 2m), "Side and heigth");
    }

    private static void PrinResult(decimal area, string method)
    {
        Console.WriteLine("The area, using the {0} method is: {1}", method, area);
    }
}
