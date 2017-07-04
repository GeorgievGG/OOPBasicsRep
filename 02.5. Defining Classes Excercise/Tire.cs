public class Tire
{
    public Tire(int age, double pressure)
    {
        this.Age = age;
        this.Pressure = pressure;
    }
    private int age;
    private double pressure;

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }
    public double Pressure
    {
        get
        {
            return this.pressure;
        }
        set
        {
            this.pressure = value;
        }
    }
}
