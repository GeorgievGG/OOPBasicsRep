public class Parent
{
    public Parent (string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }
    private string name;
    private string birthday;

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
    public override string ToString()
    {
        return $"{Name} {Birthday}";
    }
}