using System;
using System.Text;

public class Car
{
    public Car(string model, Engine engine, int? weight) : this(model, engine, weight, null)
    { }
    public Car(string model, Engine engine, string color) : this(model, engine, null, color)
    { }
    public Car(string model, Engine engine) : this(model, engine, null, null)
    { }
    public Car(string model, Engine engine, int? weight, string color)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = color;
    }
    private string model;
    private Engine engine;
    private int? weight;
    private string color;

    public string Model
    {
        get
        {
            return this.model;
        }
        private set
        {
            this.model = value;
        }
    }
    public Engine Engine
    {
        get
        {
            return this.engine;
        }
        private set
        {
            this.engine = value;
        }
    }
    public int? Weight
    {
        get
        {
            return this.weight;
        }
        private set
        {
            this.weight = value;
        }
    }
    public string Color
    {
        get
        {
            return this.color;
        }
        private set
        {
            this.color = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{this.Model}:{Environment.NewLine}  {this.Engine.ToString()}");
        if (this.Weight != null)
        {
            sb.Append($"{Environment.NewLine}  Weight: {this.Weight}");
        }
        else
        {
            sb.Append($"{Environment.NewLine}  Weight: n/a");
        }
        if (this.Color != null)
        {
            sb.Append($"{Environment.NewLine}  Color: {this.Color}");
        }
        else
        {
            sb.Append($"{Environment.NewLine}  Color: n/a");
        }
        return sb.ToString();
    }
}
