public class Cat
{
    public Cat(string name)
    {
        this.Name = name;
    }
    private string name;

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            this.name = value;
        }
    }
}