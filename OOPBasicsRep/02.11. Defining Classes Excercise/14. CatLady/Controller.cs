using System;
using System.Collections.Generic;
public class Controller
{
    public static void Main()
    {
        var input = string.Empty;
        var cats = new Dictionary<string, Cat>();
        while ((input = Console.ReadLine()) != "End")
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "Siamese":
                    cats.Add(inputArgs[1], new Siamese(inputArgs[1], int.Parse(inputArgs[2])));
                    break;
                case "Cymric":
                    cats.Add(inputArgs[1], new Cymric(inputArgs[1], double.Parse(inputArgs[2])));
                    break;
                case "StreetExtraordinaire":
                    cats.Add(inputArgs[1], new StreetExtraordinaire(inputArgs[1], int.Parse(inputArgs[2])));
                    break;
                default:
                    break;
            }
        }
        var reqCat = Console.ReadLine();
        Console.WriteLine(cats[reqCat].ToString());
    }
}