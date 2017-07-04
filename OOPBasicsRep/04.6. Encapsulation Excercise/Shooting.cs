using System;

public class Shooting : Stat
{
    public Shooting(int rating) : base(rating)
    {
        this.Rating = rating;
    }

    private int rating;

    public int Rating
    {
        get
        {
            return this.rating;
        }

        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Shooting should be between 0 and 100.");
            }
            this.rating = value;
        }
    }
}