using System;
using System.Text;

public class Box
{
    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get
        {
            return this.length;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    public double Width
    {
        get
        {
            return this.width;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public override string ToString()
    {
        var surface = (this.Length * this.Height * 2) + (this.Length * this.Width * 2) + (this.Width * this.Height * 2);
        var latSurface = surface - (this.Length * this.Width * 2);
        var sb = new StringBuilder();
        sb.AppendLine($"Surface Area - {surface:f2}");
        sb.AppendLine($"Lateral Surface Area - {latSurface:f2}");
        sb.AppendLine($"Volume - {(this.Length * this.Width * this.Height):f2}");
        return sb.ToString();
    }
}