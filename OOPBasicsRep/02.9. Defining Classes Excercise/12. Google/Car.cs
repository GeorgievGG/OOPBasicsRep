public class Car
{
    public Car(string model, int speed)
    {
        this.Model = model;
        this.Speed = speed;
    }
    private string model;
    private int speed;

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

    public int Speed
    {
        get
        {
            return this.speed;
        }

        private set
        {
            this.speed = value;
        }
    }
    public override string ToString()
    {
        return $"{Model} {Speed}";
    }
}