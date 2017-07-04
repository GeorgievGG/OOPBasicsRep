public class StreetExtraordinaire : Cat
{
    public StreetExtraordinaire(string name, int decibelsOfMews) : base(name)
    {
        this.DecibelsOfMews = decibelsOfMews;
    }
    
    private int decibelsOfMews;

    public int DecibelsOfMews
    {
        get
        {
            return this.decibelsOfMews;
        }

        set
        {
            this.decibelsOfMews = value;
        }
    }
    public override string ToString()
    {
        return $"StreetExtraordinaire {this.Name} {this.DecibelsOfMews}";
    }
}