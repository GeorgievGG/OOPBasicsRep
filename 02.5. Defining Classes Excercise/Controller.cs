using System;
using System.Collections.Generic;
using System.Linq;

public class Competition
{
    public static void Main()
    {
        var incomingCars = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        for (int i = 0; i < incomingCars; i++)
        {
            var inputParams = Console.ReadLine().Split();
            cars.Add(new Car(inputParams));
        }
        var filterType = Console.ReadLine();
        if (filterType == "fragile")
        {
            foreach (var car in cars.Where(x => x.Cargo.Type == "fragile").Where(x => x.Tires.Where(p => p.Pressure < 1).Count() != 0))
            {
                Console.WriteLine(car.Model);
            }
        }
        else if (filterType == "flamable")
        {
            foreach (var car in cars.Where(x => x.Cargo.Type == "flamable").Where(x => x.Engine.Power > 250))
            {
                Console.WriteLine(car.Model);
            }
        }
        //var drivingDirections = string.Empty;
        //while ((drivingDirections = Console.ReadLine()) != "End")
        //{
        //    var drivingArgs = drivingDirections.Split();
        //    cars[drivingArgs[1]] = Car.Drive(cars[drivingArgs[1]], double.Parse(drivingArgs[2]));
        //}
        //foreach (var car in cars)
        //{
        //    Console.WriteLine(car.Value.ToString());
        //}
    }
}