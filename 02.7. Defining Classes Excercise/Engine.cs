using System;
using System.Text;

public class Engine
{
    public Engine(string model, int power, int displacement) : this(model, power, displacement, null)
    { }
    public Engine(string model, int power, string efficiency) : this(model, power, null, efficiency)
    { }
    public Engine(string model, int power) : this(model, power, null, null)
    { }
    public Engine(string model, int power, int? displacement, string efficiency)
    {
        this.Model = model;
        this.Power = power;
        this.Displacement = displacement;
        this.Efficiency = efficiency;
    }
    private string model;
    private int power;
    private int? displacement;
    private string efficiency;

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }
    public int Power
    {
        get
        {
            return this.power;
        }
        set
        {
            this.power = value;
        }
    }
    public int? Displacement
    {
        get
        {
            return this.displacement;
        }
        set
        {
            this.displacement = value;
        }
    }
    public string Efficiency
    {
        get
        {
            return this.efficiency;
        }
        set
        {
            this.efficiency = value;
        }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{this.Model}:{Environment.NewLine}    Power: {this.Power}");
        if (this.Displacement != null)
        {
            sb.Append($"{Environment.NewLine}    Displacement: {this.Displacement}");
        }
        else
        {
            sb.Append($"{Environment.NewLine}    Displacement: n/a");
        }
        if (this.Efficiency != null)
        {
            sb.Append($"{Environment.NewLine}    Efficiency: {this.Efficiency}");
        }
        else
        {
            sb.Append($"{Environment.NewLine}    Efficiency: n/a");
        }
        return sb.ToString();
    }
}
