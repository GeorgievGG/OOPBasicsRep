using System;
using System.Collections.Generic;

public class Competition
{
    public static void Main()
    {
        var parms = Console.ReadLine().Split();
        var rectangles = int.Parse(parms[0]);
        var comparisons = int.Parse(parms[1]);
        var rectangleObjects = new Dictionary<string, Rectangle>();
        for (int i = 0; i < rectangles; i++)
        {
            var rectangleArgs = Console.ReadLine().Split();
            var leftUpperCornerCoord = new double[] { double.Parse(rectangleArgs[3]), double.Parse(rectangleArgs[4]) };
            rectangleObjects.Add(rectangleArgs[0], new Rectangle(rectangleArgs[0], double.Parse(rectangleArgs[1]), double.Parse(rectangleArgs[2]), leftUpperCornerCoord));
        }
        for (int i = 0; i < comparisons; i++)
        {
            var comparisonArgs = Console.ReadLine().Split();
            Console.WriteLine(Rectangle.Intersects(rectangleObjects[comparisonArgs[0]], rectangleObjects[comparisonArgs[1]]));
        }
    }
}