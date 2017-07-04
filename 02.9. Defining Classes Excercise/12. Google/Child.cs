public class Child
{
    public Child(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }
    private string name;
    private string birthday;

    public string Birthday
    {
        get
        {
            return this.birthday;
        }

        private set
        {
            this.birthday = value;
        }
    }

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
    public override string ToString()
    {
        return $"{Name} {Birthday}";
    }
}