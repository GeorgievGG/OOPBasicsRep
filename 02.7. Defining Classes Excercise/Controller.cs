using System;
using System.Collections.Generic;

public class Controller
{
    public static void Main()
    {
        var incomingEngines = int.Parse(Console.ReadLine());
        var engines = new Dictionary<string, Engine>();
        for (int i = 0; i < incomingEngines; i++)
        {
            var engineInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = engineInfo[0];
            var power = int.Parse(engineInfo[1]);
            if (engineInfo.Length == 2)
            {
                engines.Add(model, new Engine(model, power));
                continue;
            }
            var displacement = 0;
            var efficiency = string.Empty;
            if (engineInfo.Length == 3)
            {
                if (int.TryParse(engineInfo[2], out displacement))
                {
                    engines.Add(model, new Engine(model, power, displacement));
                    continue;
                }
                else
                {
                    efficiency = engineInfo[2];
                    engines.Add(model, new Engine(model, power, efficiency));
                    continue;
                }
            }
            else
            {
                displacement = int.Parse(engineInfo[2]);
                efficiency = engineInfo[3];
                engines.Add(model, new Engine(model, power, displacement, efficiency));
            }
        }
        var incomingCars = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        for (int i = 0; i < incomingCars; i++)
        {
            var carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = carInfo[0];
            var engineName = carInfo[1];
            var curEngine = engines[engineName];
            if (carInfo.Length == 2)
            {
                cars.Add(new Car(model, curEngine));
                continue;
            }
            var weight = 0;
            var color = string.Empty;
            if (carInfo.Length == 3)
            {
                if (int.TryParse(carInfo[2], out weight))
                {
                    cars.Add(new Car(model, curEngine, weight));
                    continue;
                }
                else
                {
                    color = carInfo[2];
                    cars.Add(new Car(model, curEngine, color));
                    continue;
                }
            }
            else
            {
                weight = int.Parse(carInfo[2]);
                color = carInfo[3];
                cars.Add(new Car(model, curEngine, weight, color));
            }
        }
        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}