using System;

/* Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Program that calculate the surface of a triangle.\n");
        Console.WriteLine("Please choose a method to Calculate the area by given:");
        Console.WriteLine("1. Side and an altitude to it.");
        Console.WriteLine("2. Three sides.");
        Console.WriteLine("3. Two sides and an angel between them.");

        while (true)
        {
            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.Write("Enter a side: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.Write("Enter an altitude: ");
                    double altitude = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area is: {0:F2}\n", CalculateAreaBySideAndAltitude(side, altitude));
                    break;
                case "2":
                    Console.Write("Enter first side: ");
                    double firstSide = double.Parse(Console.ReadLine());
                    Console.Write("Enter second side: ");
                    double secondSide = double.Parse(Console.ReadLine());
                    Console.Write("Enter third side: ");
                    double thirdSide = double.Parse(Console.ReadLine());
                    CalculateAreaByThreeSides(firstSide, secondSide, thirdSide);
                    break;
                case "3":
                    Console.Write("Enter first side: ");
                    firstSide = double.Parse(Console.ReadLine());
                    Console.Write("Enter second side: ");
                    secondSide = double.Parse(Console.ReadLine());
                    Console.Write("Enter an angle between the sides: ");
                    double angle = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area is: {0:F2}\n", CalculateAreaByTwoSidesAndAngle(firstSide, secondSide, angle));
                    break;

                default:
                    Console.WriteLine("Yor can choose between 1, 2 or 3!");
                    break;
            }
        }
    }

    static double CalculateAreaByTwoSidesAndAngle(double firstSide, double secondSide, double angle)
    {
        double area = (firstSide * secondSide * Math.Sin(angle) / 2);

        return area;
    }

    static void CalculateAreaByThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        bool rigthTriangle = ( firstSide + secondSide > thirdSide &&
                               firstSide + thirdSide > secondSide &&
                               secondSide + thirdSide > firstSide );
        
        if (rigthTriangle)
        {
            double semiperimeter = (firstSide + secondSide + thirdSide) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));
            Console.WriteLine("The area is: {0:F2}", area);
        }
        else
        {
            Console.WriteLine("Triangle with this sides cannot exits.");
        }
    }

    static double CalculateAreaBySideAndAltitude(double side, double altitude)
    {
        double area = 0;
        area = (side * altitude) / 2;

        return area;
    }
}
