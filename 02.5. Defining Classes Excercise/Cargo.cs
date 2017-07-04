public class Cargo
{
    public Cargo(int weight, string type)
    {
        this.Weight = weight;
        this.Type = type;
    }
    private int weight;
    private string type;

    public int Weight { get; set; }
    public string Type { get; set; }
}