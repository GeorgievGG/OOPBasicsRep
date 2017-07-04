public class Rectangle
{
    public Rectangle(string id, double width, double height, double[] topLeft)
    {
        this.ID = id;
        this.Width = width;
        this.Height = height;
        this.TopLeft = topLeft;
        this.BottomRight = new Coord(topLeft[0] + width, topLeft[1] - height);
    }
    private string id;
    private double width;
    private double height;
    private double[] topLeft;
    private Coord bottomRight;
    public string ID { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double[] TopLeft { get; set; }
    public Coord BottomRight
    {
        get
        {
            return this.bottomRight;
        }
        set
        {
            this.bottomRight = value;//new Coord(this.topLeft[0] + width, this.topLeft[1] - height);
        }

    }
    private static bool valueInRange(double value, double min, double max)
    {
        return ((value >= min) && (value <= max));
    }
    public static string Intersects(Rectangle rct1, Rectangle rct2)
    {
        if (rct1.TopLeft[0] <= rct2.TopLeft[0] + rct2.Width && 
            rct1.TopLeft[0] + rct1.Width >= rct2.TopLeft[0] &&
            rct1.TopLeft[1] <= rct2.TopLeft[1] + rct2.Height &&
            rct1.TopLeft[1] + rct1.Height >= rct2.TopLeft[1])
        {
            return "true";
        }
        return "false";
    }
}