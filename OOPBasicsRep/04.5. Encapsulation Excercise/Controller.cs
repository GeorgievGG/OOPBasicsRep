using System;
using System.Collections.Generic;

public class Competition
{
    public static void Main()
    {
        var data = new List<string>();
        var input = string.Empty;
        while ((input = Console.ReadLine()) != "END")
        {
            data.Add(input);
        }
        if (data.Count == 1)
        {
            foreach (var line in data)
            {

                var inputArgs = line.Split();
                try
                {
                    var newDough = new Dough(double.Parse(inputArgs[3]), inputArgs[1], inputArgs[2]);
                    Console.WriteLine($"{newDough.Calories:f2}");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }
        }
        else if (data.Count == 2)
        {
            foreach (var line in data)
            {
                var inputArgs = line.Split();
                if (inputArgs[0] == "Dough")
                {
                    try
                    {
                        var newDough = new Dough(double.Parse(inputArgs[3]), inputArgs[1], inputArgs[2]);
                        Console.WriteLine($"{newDough.Calories:f2}");
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                else
                {
                    try
                    {
                        var newTopping = new Topping(double.Parse(inputArgs[2]), inputArgs[1]);
                        Console.WriteLine($"{newTopping.Calories:f2}");
                        return;
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        return;
                    }
                }
            }
        }
        else
        {
            Pizza newPizza = null;
            var toppings = 0;
            for (int i = 0; i < data.Count; i++)
            {
                var inputArgs = data[i].Split();

                if (i > toppings + 1)
                {
                    break;
                }
                if (i == 0)
                {
                    try
                    {
                        newPizza = new Pizza(inputArgs[1], int.Parse(inputArgs[2]));
                        toppings = int.Parse(inputArgs[2]);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        return;
                    }
                }
                else if (inputArgs[0] == "Dough")
                {
                    try
                    {
                        newPizza.Dough = new Dough(double.Parse(inputArgs[3]), inputArgs[1], inputArgs[2]);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        return;
                    }
                }
                else if (inputArgs[0] == "Topping")
                {
                    try
                    {
                        newPizza.AddTopping(new Topping(double.Parse(inputArgs[2]), inputArgs[1]));
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        return;
                    }
                }
            }
            Console.WriteLine($"{newPizza.Name} - {newPizza.TotalCalories:f2} Calories.");
        }
    }
}