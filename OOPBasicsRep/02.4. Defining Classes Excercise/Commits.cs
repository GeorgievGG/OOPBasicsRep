using System;
using System.Collections.Generic;
public class Competition
{
    public static void Main()
    {
        var incomingCars = int.Parse(Console.ReadLine());
        var cars = new Dictionary<string, Car>();
        for (int i = 0; i < incomingCars; i++)
        {
            var inputParams = Console.ReadLine().Split();
            cars.Add(inputParams[0], new Car(inputParams[0], double.Parse(inputParams[1]), double.Parse(inputParams[2])));

        }
        var drivingDirections = string.Empty;
        while ((drivingDirections = Console.ReadLine()) != "End")
        {
            var drivingArgs = drivingDirections.Split();
            cars[drivingArgs[1]] = Car.Drive(cars[drivingArgs[1]], double.Parse(drivingArgs[2]));
        }
        foreach (var car in cars)
        {
            Console.WriteLine(car.Value.ToString());
        }
    }
}