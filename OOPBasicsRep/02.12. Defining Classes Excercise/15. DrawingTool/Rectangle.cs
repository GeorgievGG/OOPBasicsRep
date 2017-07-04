public class Rectangle
{
    public Rectangle(int a, int b)
    {
        this.A = a;
        this.B = b;
    }
    private int a;
    private int b;

    public int A
    {
        get
        {
            return this.a;
        }

        set
        {
            this.a = value;
        }
    }

    public int B
    {
        get
        {
            return this.b;
        }

        set
        {
            this.b = value;
        }
    }
}