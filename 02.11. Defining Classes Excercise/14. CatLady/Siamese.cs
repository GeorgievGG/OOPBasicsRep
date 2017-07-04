public class Siamese : Cat
{
    public Siamese(string name, int earSize) : base(name)
    {
        this.EarSize = earSize;
    }
    private int earSize;
    public int EarSize
    {
        get
        {
            return this.earSize;
        }

        set
        {
            this.earSize = value;
        }
    }
    public override string ToString()
    {
        return $"Siamese {this.Name} {this.EarSize}";
    }
}