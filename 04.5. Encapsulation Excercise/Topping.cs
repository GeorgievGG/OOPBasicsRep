using System;

public class Topping
{
    public Topping(double weight, string type)
    {
        this.Type = type;
        this.Weight = weight;
    }
    private double weight;
    private string type;

    public double Weight
    {
        get
        {
            return this.weight;
        }

        private set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
            }
            this.weight = value;
        }
    }

    public string Type
    {
        get
        {
            return this.type;
        }

        private set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.type = value;
        }
    }
    public double Calories
    {
        get
        {
            var calories = 2 * this.Weight;
            switch (this.Type.ToLower())
            {
                case "meat":
                    calories *= 1.2;
                    break;
                case "veggies":
                    calories *= 0.8;
                    break;
                case "cheese":
                    calories *= 1.1;
                    break;
                case "sauce":
                    calories *= 0.9;
                    break;
                default:
                    break;
            }
            return calories;
        }
    }
}