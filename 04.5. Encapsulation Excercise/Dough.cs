using System;

public class Dough
{
    public Dough(double weight, string flourType, string type)
    {
        this.Weight = weight;
        this.FlourType = flourType;
        this.Type = type;
    }
    private double weight;
    private string flourType;
    private string type;

    public double Weight
    {
        get
        {
            return this.weight;
        }

        private set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            this.weight = value;
        }
    }

    public string FlourType
    {
        get
        {
            return this.flourType;
        }

        private set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flourType = value;
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
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.type = value;
        }
    }

    public double Calories
    {
        get
        {
            var calories = 2 * this.Weight;
            if (this.FlourType.ToLower() == "white")
            {
                calories *= 1.5;
            }
            else if (this.FlourType.ToLower() == "wholegrain")
            {
                calories *= 1.0;
            }
            switch (this.Type.ToLower())
            {
                case "crispy":
                    calories *= 0.9;
                    break;
                case "chewy":
                    calories *= 1.1;
                    break;
                case "homemade":
                    calories *= 1;
                    break;
                default:
                    break;
            }
            return calories;
        }
    }
}