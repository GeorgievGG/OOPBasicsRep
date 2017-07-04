using System;

public class Car
{
    public Car(string[] carParams)
    {
        this.Model = carParams[0];
        this.Engine = new Engine(int.Parse(carParams[1]), int.Parse(carParams[2]));
        this.Cargo = new Cargo(int.Parse(carParams[3]), carParams[4]);
        this.Tires = new Tire[4];
        for (int i = 0; i < 8; i += 2)
        {
            Tires[i / 2] = new Tire(int.Parse(carParams[5 + i + 1]), double.Parse(carParams[5 + i]));
        }
    }
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tires;

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
    public Engine Engine
    {
        get
        {
            return this.engine;
        }
        set
        {
            this.engine = value;
        }
    }
    public Cargo Cargo
    {
        get
        {
            return this.cargo;
        }
        set
        {
            this.cargo = value;
        }
    }
    public Tire[] Tires
    {
        get
        {
            return this.tires;
        }
        set
        {
            this.tires = value;
        }
    }

    //public override string ToString()
    //{
    //    return $"{model} {fuel:f2} {distanceTraveled}";
    //}
}
