using System;

public class Car
{
    public Car(string model, double fuel, double fuelConsumption)
    {
        this.Model = model;
        this.Fuel = fuel;
        this.FuelConsumptionPerKm = fuelConsumption;
    }
    private string model;
    private double fuel;
    private double fuelConsumptionPerKm;
    private double distanceTraveled = 0;

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
    public double Fuel
    {
        get
        {
            return this.fuel;
        }
        set
        {
            this.fuel = value;
        }
    }
    public double FuelConsumptionPerKm
    {
        get
        {
            return this.fuelConsumptionPerKm;
        }
        set
        {
            this.fuelConsumptionPerKm = value;
        }
    }
    public double DistanceTraveled { get; set; }

    public static Car Drive(Car car, double kmsToDrive)
    {
        if (kmsToDrive * car.fuelConsumptionPerKm > car.fuel)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            car.fuel -= kmsToDrive * car.fuelConsumptionPerKm;
            car.distanceTraveled += kmsToDrive;
        }
        return car;
    }

    public override string ToString()
    {
        return $"{model} {fuel:f2} {distanceTraveled}";
    }
}
