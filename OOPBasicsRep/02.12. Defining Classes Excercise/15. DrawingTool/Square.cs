public class Square : Rectangle
{
    public Square(int a) : base(a, a)
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